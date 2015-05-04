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
        /// Time controlling the speed at which the ball blinks
        /// </summary>
        private Timer _ballBlinkTimer;
        
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
        public Catcher(ref CubeController.Cube cube)
        {
            _cube = cube;
            _currentPlane = 0;
            _currentDirection = DIRECTION.POSITIVE_X;
            _random = new Random();
            _gameTimer = new Timer();
            _ballBlinkTimer = new Timer();
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
            _ballBlinkTimer.Tick += BallTimerTick;
        }

        /// <summary>
        /// Starts a new game
        /// </summary>
        public void StartNewGame()
        {
            _gameIsPlaying = true;
            _score = 0;
            _ballBlinkTimer.Interval = 1000 / 4;
            _gameTimer.Start();
            _ballBlinkTimer.Start();            
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
            _ballBlinkTimer.Stop();
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
        /// Flashes the ball voxel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BallTimerTick(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Spawns a new food piece in a random, unoccupied location
        /// </summary>
        private void SpawnFood()
        {
        }
        
        /// <summary>
        /// Handles every tick of the game timer. This actually drives the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameTimerTick(object sender, EventArgs e)
        {
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
}
