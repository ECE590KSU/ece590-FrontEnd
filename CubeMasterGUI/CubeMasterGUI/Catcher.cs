using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeMasterGUI
{
    public class Catcher
    {
        /// <summary>
        /// The cube controller
        /// </summary>
        private CubeController.Cube _cube;
        
        /// <summary>
        /// Lookup dictionary for difficulties
        /// </summary>
        private Dictionary<string, DIFFICULTY> _difficultyDictionary;

        /// <summary>
        /// The "basket" on the bottom layer of the cube
        /// </summary>
        private Basket _basket;

        /// <summary>
        /// The "ball" which is dropping through the cube
        /// </summary>
        private Ball _ball;

        /// <summary>
        /// Interval determining the speed at which the ball drops
        /// </summary>
        private int _ballTimeInterval;

        /// <summary>
        /// Timer controlling the flashing on the GUI
        /// </summary>
        private Timer _flashTimer;

        /// <summary>
        /// Current score
        /// </summary>
        private int _score;

        /// <summary>
        /// Current plane
        /// </summary>
        private int _currentPlane;
        
        /// <summary>
        /// Current difficulty
        /// </summary>
        private string _currentDifficulty;

        /// <summary>
        /// Timer controlling the game
        /// </summary>
        private Timer _gameTimer;

        /// <summary>
        /// Time controlling the speed at which the ball blinks
        /// </summary>
        private Timer _ballTimer;
        
        /// <summary>
        /// Is a game currently being played
        /// </summary>
        private bool _gameIsPlaying = false;

        /// <summary>
        /// Random object used for food generation
        /// </summary>
        private Random _random;

        /// <summary>
        /// StreamWriter for saving high scores
        /// </summary>
        private StreamWriter _streamWriter;

        /// <summary>
        /// StreamReader for reading the saved high scores
        /// </summary>
        private StreamReader _streamReader;

        /// <summary>
        /// List of the current high scores
        /// </summary>
        private List<HighScore> _highScores;

        /// <summary>
        /// Data structure to bind the high scores to a list box
        /// </summary>
        private BindingList<string> _boundHighScores;

        /// <summary>
        /// The different directions that the snake head can be oriented
        /// </summary>
        private enum DIRECTION { POSITIVE_X, POSITIVE_Y, NEGATIVE_X, NEGATIVE_Y, POSITIVE_Z, NEGATIVE_Z };

        /// <summary>
        /// The different game difficutly settings
        /// </summary>
        private enum DIFFICULTY { EASY, MEDIUM, HARD };

        /// <summary>
        /// Event handler for when the game is ended
        /// </summary>
        public event EventHandler GameOver;
        
        /// <summary>
        /// Constructor for a new Snake controller
        /// </summary>
        /// <param name="cube">Cube controller</param>
        public Catcher(ref CubeController.Cube cube)
        {
            _cube = cube;
            _currentPlane = 0;
            _ballTimeInterval = 350;
            _random = new Random();
            _gameTimer = new Timer();
            _ballTimer = new Timer();
            _basket = new Basket(3, 3, _cube.Dimension);
            _ball = new Ball();
            _highScores = new List<HighScore>();
            _boundHighScores = new BindingList<string>();
            _difficultyDictionary = new Dictionary<string, DIFFICULTY>
            {
                {"btnEasy", DIFFICULTY.EASY},
                {"btnMedium", DIFFICULTY.MEDIUM},
                {"btnHard", DIFFICULTY.HARD}
            };
            ReadHighScores();
            _flashTimer = new Timer();
            _flashTimer.Tick += FlashTick;
            _gameTimer.Tick += GameTimerTick;
            _ballTimer.Tick += BallTimerTick;
        }

        /// <summary>
        /// Handles a game over event
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnGameOver(EventArgs e)
        {
            EventHandler handler = GameOver;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        /// <summary>
        /// Starts a new game
        /// </summary>
        public void StartNewGame()
        {
            _gameIsPlaying = true;
            switch(_currentDifficulty)
            {
                case "Easy":
                    _basket.Reset(3, 3);
                    break;
                case "Med":
                    _basket.Reset(3, 2);
                    break;
                case "Hard":
                    _basket.Reset(2, 2);
                    break;
                default:
                    break;
            }
            _score = 0;
            _gameTimer.Interval = 1000 / 60;
            _flashTimer.Interval = 1000 / 4;
            _ballTimer.Interval = _ballTimeInterval;
            _gameTimer.Start();
            //_flashTimer.Start();
            _ballTimer.Start();            
        }

        /// <summary>
        /// Ends the current game being played
        /// </summary>
        public void EndGame()
        {
            if (!_gameIsPlaying)
                return;
            else
                _gameIsPlaying = false;

            _gameTimer.Stop();
            _ballTimer.Stop();
            _flashTimer.Stop();
            if (_score > _highScores.Last().Score)
            {
                GenerateHighScoreDialog();
            }
            else
            {
                MessageBox.Show("Game Over!");
            }
            _cube.ClearEntireCube();

        }

        /// <summary>
        /// Changed the difficulty setting
        /// </summary>
        /// <param name="s">Button name of the currently selected difficulty</param>
        public void ChangeDifficultySetting(string s)
        {
            DIFFICULTY diff = _difficultyDictionary[s];
            switch (diff)
            {
                case DIFFICULTY.EASY:
                    _currentDifficulty = "Easy";
                    break;
                case DIFFICULTY.MEDIUM:
                    _currentDifficulty = "Med";
                    break;
                case DIFFICULTY.HARD:
                    _currentDifficulty = "Hard";
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Moves the basket based on a key press
        /// </summary>
        /// <param name="key">Key that was pressed</param>
        public void MoveBasket(Keys key)
        {
            switch (key)
            {
                case Keys.Left:
                case Keys.A:
                    _basket.MoveX(-1);
                    break;
                case Keys.Right:
                case Keys.D:
                    _basket.MoveX(1);
                    break;
                case Keys.Up:
                case Keys.W:
                    _basket.MoveY(1);
                    break;
                case Keys.Down:
                case Keys.S:
                    _basket.MoveY(-1);
                    break;
                default:
                    break;
            }
        }
        
        /// <summary>
        /// Updates the binding list of high scores
        /// </summary>
        /// <returns>High scores to be bound to a list box</returns>
        public BindingList<string> RefreshHighScores()
        {
            _boundHighScores.Clear();
            foreach (var h in _highScores)
            {
                _boundHighScores.Add(h.ToString());
            }
            return _boundHighScores;
        }

        /// <summary>
        /// Get the current plane
        /// </summary>
        /// <returns>current plane</returns>
        public bool[][] GetPlane()
        {
            return _cube.GetPlane(CubeController.Cube.AXIS.AXIS_Z, _currentPlane);
        }

        /// <summary>
        /// Gets the current score
        /// </summary>
        /// <returns>Current score</returns>
        public string GetScore()
        {
            return _score.ToString();
        }

        /// <summary>
        /// Displays the current basket location on the cube
        /// </summary>
        private void DisplayBasket()
        {
            _cube.ClearPlane(CubeController.Cube.AXIS.AXIS_Z, 0);

            for (int x = _basket.XMin; x < _basket.XMax; x++)
            {
                for (int y = _basket.YMin; y < _basket.YMax; y++)
                {
                    _cube.SetVoxel(x, y, 0);
                }
            }
        }

        /// <summary>
        /// Flashes the ball voxel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BallTimerTick(object sender, EventArgs e)
        {
            if (_ball.Z > 1)
            {
                _cube.SwapVoxel(_ball.X, _ball.Y, _ball.Z);
                _ball.Z--;
                _cube.SwapVoxel(_ball.X, _ball.Y, _ball.Z);
            }
            else
            {
                _cube.SwapVoxel(_ball.X, _ball.Y, _ball.Z);
                _ball.Z--; // _ball.Z is now 0
                if (_basket.BallIsCaugh(_ball.X, _ball.Y))
                {
                    _score++;
                    UpdateBallTimer();   
                    SpawnBall();
                }
                else
                {
                    FireEndGame();
                }
            }
        }

        /// <summary>
        /// Fires the end of game event
        /// </summary>
        private void FireEndGame()
        {
            OnGameOver(EventArgs.Empty);
        }

        /// <summary>
        /// Updates the ball timer to a new interval
        /// </summary>
        private void UpdateBallTimer()
        {
            // this needs to be tested on the cube to see if it's fun
            if (_ballTimeInterval >= 75)
            {
                _ballTimeInterval -= 5;
                _ballTimer.Interval = _ballTimeInterval;
            }
        }

        /// <summary>
        /// Tick for the timer that handles the flashing on the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlashTick(object sender, EventArgs e)
        {
            _cube.SwapVoxel(_ball.X, _ball.Y, 0);
        }

        /// <summary>
        /// Spawns a new ball piece in a random, unoccupied location
        /// </summary>
        private void SpawnBall()
        {
            _ball.X = _random.Next(_cube.Dimension);
            _ball.Y = _random.Next(_cube.Dimension);
            _ball.Z = 7;
            _cube.SwapVoxel(_ball.X, _ball.Y, _ball.Z);
            _cube.SetVoxel(_ball.X, _ball.Y, 0);
        }
        
        /// <summary>
        /// Handles every tick of the game timer. This actually drives the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameTimerTick(object sender, EventArgs e)
        {
            DisplayBasket();
        }

        /// <summary>
        /// Create a new HighScore user control embedded in a form
        /// </summary>
        private void GenerateHighScoreDialog()
        {
            HighScoreWindow highScoreWindow = new HighScoreWindow();
            Form form = new Form();
            form.Controls.Add(highScoreWindow);
            highScoreWindow.Dock = DockStyle.Fill;
            form.Size = new System.Drawing.Size(410, 195);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _highScores.Add(new HighScore(highScoreWindow.txtBoxName.Text, _score, _currentDifficulty));
                _highScores = (from s in _highScores
                               orderby s.Score descending
                               select s).ToList();
                WriteHighScores();
                RefreshHighScores();
            }
        }
                
        /// <summary>
        /// Save the high score list to a file
        /// </summary>
        private void WriteHighScores()
        {
            File.WriteAllText(AssetHandler._catcherHighScoreURL, "");
            _streamWriter = new StreamWriter(AssetHandler._catcherHighScoreURL);
            foreach (var h in _highScores)
            {
                _streamWriter.WriteLine(h.Name + "," + h.Score + "," + h.Difficulty);
            }
            _streamWriter.Close();
        }
        
        /// <summary>
        /// Read the high scores from the .csv file
        /// </summary>
        private void ReadHighScores()
        {
            string line;
            _streamReader = new StreamReader(AssetHandler._catcherHighScoreURL);
            while ((line = _streamReader.ReadLine()) != null) 
            {
                string[] tokens = line.Split(',');
                _highScores.Add(new HighScore(tokens[0], Convert.ToInt32(tokens[1]), tokens[2]));
            }
            _streamReader.Close();
        }
    }

    /// <summary>
    /// Class representing a "basket" which can catch "balls"
    /// </summary>
    internal class Basket
    {
        /// <summary>
        /// Size of basket in the x dimension
        /// </summary>
        private int _xDimension;

        /// <summary>
        /// Size of basket in the y dimension
        /// </summary>
        private int _yDimension;

        /// <summary>
        /// Current furthest left point of the basket
        /// </summary>
        private int _xOriginLocation;

        /// <summary>
        /// Current furthest bottom point of basket
        /// </summary>
        private int _yOriginLocation;

        /// <summary>
        /// Dimension of the game board. Assumes a square.
        /// </summary>
        private int _boardDimension;

        /// <summary>
        /// Constructor for a basket
        /// </summary>
        /// <param name="x">X size of the basket</param>
        /// <param name="y">Y size of the basket</param>
        /// <param name="boardDimension">Board dimension assuming a square</param>
        public Basket(int x, int y, int boardDimension)
        {
            _xDimension = x;
            _yDimension = y;
            _xOriginLocation = 0;
            _yOriginLocation = 0;
            _boardDimension = boardDimension;
        }

        /// <summary>
        /// If possible, moves along the x-axis that amount
        /// </summary>
        /// <param name="amount">Number of spaces to move</param>
        public void MoveX(int amount)
        {
            int temp = _xOriginLocation;
            _xOriginLocation += amount;
            if (_xOriginLocation < 0 || _xOriginLocation + _xDimension > _boardDimension)
            {
                _xOriginLocation = temp;
            }
        }

        /// <summary>
        /// If possible, moves along the y-axis that amount
        /// </summary>
        /// <param name="amount">Number of space to move</param>
        public void MoveY(int amount)
        {
            int temp = _yOriginLocation;
            _yOriginLocation += amount;
            if (_yOriginLocation < 0 || _yOriginLocation + _yDimension > _boardDimension)
            {
                _yOriginLocation = temp;
            }
        }

        /// <summary>
        /// Determines if the ball is caught in the basket
        /// </summary>
        /// <param name="x">X-coordinate of the ball</param>
        /// <param name="y">Y-coordinate of the ball</param>
        /// <returns></returns>
        public bool BallIsCaugh(int x, int y)
        {
            if ((x >= _xOriginLocation) && (x < _xOriginLocation + _xDimension) &&
                (y >= _yOriginLocation) && (y < _yOriginLocation + _yDimension))
                return true;
            return false;
        }

        /// <summary>
        /// Reset the basket to a location
        /// </summary>
        /// <param name="x">X-coordinate to reset to</param>
        /// <param name="y">Y-coordinate to reset to</param>
        public void Reset(int x, int y)
        {
            _xOriginLocation = 0;
            _yOriginLocation = 0;
            _xDimension = x;
            _yDimension = y;
        }

        /// <summary>
        /// The furthest left the basket currently is
        /// </summary>
        public int XMin
        {
            get { return _xOriginLocation; }
        }

        /// <summary>
        /// The furthest down the basket currently is
        /// </summary>
        public int YMin
        {
            get { return _yOriginLocation; }
        }

        /// <summary>
        /// The furthest right the basket currently is
        /// </summary>
        public int XMax
        {
            get { return _xOriginLocation + _xDimension; }
        }

        /// <summary>
        /// The furthest up the basket currently is
        /// </summary>
        public int YMax
        {
            get { return _yOriginLocation + _yDimension; }
        }
    }

    /// <summary>
    /// Represents a "ball" to be caught by a Basket
    /// </summary>
    internal class Ball
    {
        /// <summary>
        /// X-Coordinate
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y-Coordinate
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Z-Coordinate
        /// </summary>
        public int Z { get; set; }
    }
}
