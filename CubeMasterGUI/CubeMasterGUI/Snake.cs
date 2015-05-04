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
    public class Snake
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
        /// Current direction of the head of the snake
        /// </summary>
        private DIRECTION _currentDirection;

        /// <summary>
        /// Timer controlling the game
        /// </summary>
        private Timer _gameTimer;

        /// <summary>
        /// Time controlling the speed at which the food blinks
        /// </summary>
        private Timer _foodBlinkTimer;

        /// <summary>
        /// Snake section representing the head of the snake
        /// </summary>
        private SnakeSection _head;

        /// <summary>
        /// A snake section represented the current food item
        /// </summary>
        private SnakeSection _food;

        /// <summary>
        /// The entire snake (including head)
        /// </summary>
        private List<SnakeSection> _snake;

        /// <summary>
        /// Is a food piece out on the cube
        /// </summary>
        private bool _foodIsOnTheTable = false;

        /// <summary>
        /// It the snake head in the same position as the food piece
        /// </summary>
        private bool _eating = false;

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
        /// Constructor for a new Snake controller
        /// </summary>
        /// <param name="cube">Cube controller</param>
        public Snake(ref CubeController.Cube cube)
        {
            _cube = cube;
            _currentPlane = 0;
            _currentDirection = DIRECTION.POSITIVE_X;
            _head = new SnakeSection();
            _food = new SnakeSection();
            _snake = new List<SnakeSection>();
            _random = new Random();
            _gameTimer = new Timer();
            _foodBlinkTimer = new Timer();
            _highScores = new List<HighScore>();
            _boundHighScores = new BindingList<string>();
            _difficultyDictionary = new Dictionary<string, DIFFICULTY>
            {
                {"btnEasy", DIFFICULTY.EASY},
                {"btnMedium", DIFFICULTY.MEDIUM},
                {"btnHard", DIFFICULTY.HARD}
            };
            ReadHighScores();

            _gameTimer.Tick += GameTimerTick;
            _foodBlinkTimer.Tick += FoodTimerTick;
        }

        /// <summary>
        /// Starts a new game
        /// </summary>
        public void StartNewGame()
        {
            _gameIsPlaying = true;
            _score = 0;
            _snake.Add(_head);
            _foodBlinkTimer.Interval = 1000 / 4;
            _gameTimer.Start();
            _foodBlinkTimer.Start();            
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
            _foodBlinkTimer.Stop();
            if (_score > _highScores.Last().Score)
            {
                GenerateHighScoreDialog();
            }
            else
            {
                MessageBox.Show("Game Over!");
            }
            _snake.Clear();
            _head.Reset();
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
                    _gameTimer.Interval = 700;
                    _currentDifficulty = "Easy";
                    break;
                case DIFFICULTY.MEDIUM:
                    _gameTimer.Interval = 400;
                    _currentDifficulty = "Med";
                    break;
                case DIFFICULTY.HARD:
                    _gameTimer.Interval = 175;
                    _currentDifficulty = "Hard";
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
        /// Changes the current direction based on a key press
        /// </summary>
        /// <param name="key">Key that was pressed</param>
        public void ChangeCurrentDirection(Keys key)
        {
            switch (key)
            {
                case Keys.Left:
                case Keys.A:
                    switch (_currentDirection)
                    {
                        case DIRECTION.NEGATIVE_Y:
                        case DIRECTION.NEGATIVE_Z:
                            _currentDirection = DIRECTION.POSITIVE_X;
                            break;
                        case DIRECTION.POSITIVE_Z:
                            _currentDirection = DIRECTION.NEGATIVE_X;
                            break;
                        default:
                            _currentDirection++;
                            break;
                    }
                    break;
                case Keys.Right:
                case Keys.D:
                    switch (_currentDirection)
                    {
                        case DIRECTION.POSITIVE_X:
                            _currentDirection = DIRECTION.NEGATIVE_Y;
                            break;
                        case DIRECTION.POSITIVE_Z:
                            _currentDirection = DIRECTION.POSITIVE_X;
                            break;
                        case DIRECTION.NEGATIVE_Z:
                            _currentDirection = DIRECTION.NEGATIVE_X;
                            break;
                        default:
                            _currentDirection--;
                            break;
                    }
                    break;
                case Keys.Up:
                case Keys.W:
                    switch (_currentDirection)
                    {
                        case DIRECTION.POSITIVE_Z:
                            _currentDirection = DIRECTION.NEGATIVE_Y;
                            break;
                        case DIRECTION.NEGATIVE_Z:
                            _currentDirection = DIRECTION.POSITIVE_Y;
                            break;
                        default:
                            _currentDirection = DIRECTION.POSITIVE_Z;
                            break;
                    }
                    break;
                case Keys.Down:
                case Keys.S:
                    switch (_currentDirection)
                    {
                        case DIRECTION.POSITIVE_Z:
                            _currentDirection = DIRECTION.POSITIVE_Y;
                            break;
                        case DIRECTION.NEGATIVE_Z:
                            _currentDirection = DIRECTION.NEGATIVE_Y;
                            break;
                        default:
                            _currentDirection = DIRECTION.NEGATIVE_Z;
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Flashes the food voxel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FoodTimerTick(object sender, EventArgs e)
        {
            if (_foodIsOnTheTable)
                _cube.SwapVoxel(_food.X, _food.Y, 0);
        }

        /// <summary>
        /// Spawns a new food piece in a random, unoccupied location
        /// </summary>
        private void SpawnFood()
        {
            bool valid = false;
            while (!valid)
            {
                _food.X = _random.Next(_cube.Dimension);
                _food.Y = _random.Next(_cube.Dimension);
                _food.Z = 0;
                //_food.Z = _random.Next(_cube.Dimension);
                valid = true;
                foreach (var s in _snake)
                {
                    if (_food == s)
                        valid = false;
                }
            }
            _foodIsOnTheTable = true;
            _cube.SetVoxel(_food.X, _food.Y, 0);
            //_cube.SetVoxel(_food.X, _food.Y, _food.Z);
            // TODO: uncomment these two lines and delete the lines they replace
        }
        
        /// <summary>
        /// Handles every tick of the game timer. This actually drives the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameTimerTick(object sender, EventArgs e)
        {
            if (!_foodIsOnTheTable)
                SpawnFood();
            
            if (_food == _head)
            {
                _snake.Add(new SnakeSection(_head.X, _head.Y, _head.Z));
                _eating = true;
                _score++;
                SpawnFood();
            }

            DisplaySnake();

            if (CheckForCollision())
            {
                EndGame();
            }
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
        /// Displays the snake on the cube
        /// </summary>
        private void DisplaySnake()
        {
            int count = _snake.Count;
            _cube.SetVoxel(_head.X, _head.Y, _head.Z);

            if (!_eating)
                _cube.ClearVoxel(_snake[count - 1].X, _snake[count - 1].Y, _snake[count - 1].Z);
            else
            {
                _cube.SetVoxel(_snake[count - 1].X, _snake[count - 1].Y, _snake[count - 1].Z);
                _eating = false;
            }

            for (int i = count - 1; i > 0; i--)
            {
                _snake[i].X = _snake[i - 1].X;
                _snake[i].Y = _snake[i - 1].Y;
                _snake[i].Z = _snake[i - 1].Z;
            }
            MoveHeadOfSnake();
            _currentPlane = _head.Z;
            _cube.SetVoxel(_head.X, _head.Y, _head.Z);
        }

        /// <summary>
        /// Moves the head of the snake according to the currentDirection
        /// </summary>
        private void MoveHeadOfSnake()
        {
            switch (_currentDirection)
            {
                case DIRECTION.POSITIVE_X:
                    _head.X++;
                    _head.X %= _cube.Dimension;
                    break;
                case DIRECTION.POSITIVE_Y:
                    _head.Y++;
                    _head.Y %= _cube.Dimension;
                    break;
                case DIRECTION.POSITIVE_Z:
                    _head.Z++;
                    _head.Z %= _cube.Dimension;
                    break;
                case DIRECTION.NEGATIVE_X:
                    if (_head.X == 0)
                        _head.X = _cube.Dimension - 1;
                    else
                        _head.X--;
                    break;
                case DIRECTION.NEGATIVE_Y:
                    if (_head.Y == 0)
                        _head.Y = _cube.Dimension - 1;
                    else
                        _head.Y--;
                    break;
                case DIRECTION.NEGATIVE_Z:
                    if (_head.Z == 0)
                        _head.Z = _cube.Dimension - 1;
                    else
                        _head.Z--;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Checks if the snake has collided with itself
        /// </summary>
        /// <returns>Has the snake collided</returns>
        private bool CheckForCollision()
        {
            for (int i = 1; i < _snake.Count; i++)
            {
                if (_head == _snake[i])
                    return true;
            }
            return false;
        }
        
        /// <summary>
        /// Save the high score list to a file
        /// </summary>
        private void WriteHighScores()
        {
            File.WriteAllText(AssetHandler._snakeHighScoreURL, "");
            _streamWriter = new StreamWriter(AssetHandler._snakeHighScoreURL);
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
            _streamReader = new StreamReader(AssetHandler._snakeHighScoreURL);
            while ((line = _streamReader.ReadLine()) != null) 
            {
                string[] tokens = line.Split(',');
                _highScores.Add(new HighScore(tokens[0], Convert.ToInt32(tokens[1]), tokens[2]));
            }
            _streamReader.Close();
        }
        
    }

    /// <summary>
    /// Class representing a single section of a snake
    /// </summary>
    internal class SnakeSection
    {
        /// <summary>
        /// X-coordinate
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y-coordinate
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Z-coordinate
        /// </summary>
        public int Z { get; set; }

        /// <summary>
        /// Default constructor for SnakeSection. Sets location at (0,0,0)
        /// </summary>
        public SnakeSection()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        /// <summary>
        /// Constructor to set location of SnakeSection at (x,y,z)
        /// </summary>
        /// <param name="x">X-coordinate</param>
        /// <param name="y">Y-coordinate</param>
        /// <param name="z">Z-coordinate</param>
        public SnakeSection(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Resets the sections location to (0,0,0)
        /// </summary>
        public void Reset()
        {
            X = 0;
            Y = 0;
            Z = 0;       
        }

        /// <summary>
        /// Overloads the == operator to be a.X == b.x && a.Y == b.Y && a.Z == b.Z
        /// </summary>
        /// <param name="a">First section to compare</param>
        /// <param name="b">Second section to compare</param>
        /// <returns></returns>
        public static bool operator ==(SnakeSection a, SnakeSection b)
        {
            if (Object.ReferenceEquals(a,b))
                return true;
            if (((object)a == null) || ((object)b == null)) 
                return false;
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        /// <summary>
        /// Overloads the != operator to be a.X != b.x || a.Y != b.Y || a.Z != b.Z
        /// </summary>
        /// <param name="a">First section to compare</param>
        /// <param name="b">Second section to compare</param>
        /// <returns></returns>
        public static bool operator !=(SnakeSection a, SnakeSection b)
        {
            return !(a == b);
        }
    }
}
