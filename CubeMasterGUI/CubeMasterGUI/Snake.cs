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
        private const int DIMENSION = 8;
        private CubeController.Cube _cube;
        private Dictionary<string, DIFFICULTY> _difficultyDictionary;
        private int _score;
        private int _currentPlane;

        private enum DIRECTION { POSITIVE_X, POSITIVE_Y, NEGATIVE_X, NEGATIVE_Y, POSITIVE_Z, NEGATIVE_Z };
        private enum DIFFICULTY { EASY, MEDIUM, HARD };

        private DIRECTION _currentDirection;
        private Timer _gameTimer;
        private Timer _foodBlinkTimer;

        private SnakeSection _head;
        private SnakeSection _food;
        private List<SnakeSection> _snake;

        private bool _foodIsOnTheTable = false;
        private bool _eating = false;

        private Random _random;

        private StreamWriter _streamWriter;
        private StreamReader _streamReader;
        private List<HighScore> _highScores;
        private BindingList<string> _boundHighScores;
        
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

        public void StartNewGame()
        {
            _score = 0;
            _snake.Add(_head);
            _foodBlinkTimer.Interval = 1000 / 4;
            _gameTimer.Start();
            _foodBlinkTimer.Start();            
        }

        private void FoodTimerTick(object sender, EventArgs e)
        {
            if (_foodIsOnTheTable)
                _cube.SwapVoxel(_food.X, _food.Y, 0);
        }

        private void SpawnFood()
        {
            bool valid = false;
            while (!valid)
            {
                _food.X = _random.Next(DIMENSION);
                _food.Y = _random.Next(DIMENSION);
                _food.Z = 0;
                //_food.Z = _random.Next(DIMENSION);
                valid = true;
                foreach (var s in _snake)
                {
                    if (_food == s)
                        valid = false;
                }
            }
            _foodIsOnTheTable = true;
            _cube.SetVoxel(_food.X, _food.Y, 0); // TODO: need to change this to _food.Z
        }

        public void ChangeDifficultySetting(string s)
        {
            DIFFICULTY diff = _difficultyDictionary[s];
            switch(diff)
            {
                case DIFFICULTY.EASY:
                    _gameTimer.Interval = 700;
                    break;
                case DIFFICULTY.MEDIUM:
                    _gameTimer.Interval = 400;
                    break;
                case DIFFICULTY.HARD:
                    _gameTimer.Interval = 175;
                    break;
                default:
                    break;
            }
        }

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

        public void EndGame()
        {
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

        private void GenerateHighScoreDialog()
        {
            HighScoreWindow highScoreWindow = new HighScoreWindow();
            Form form = new Form();
            form.Controls.Add(highScoreWindow);
            highScoreWindow.Dock = DockStyle.Fill;
            form.Size = new System.Drawing.Size(410, 195);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _highScores.Add(new HighScore(highScoreWindow.txtBoxName.Text, _score));
                _highScores = (from s in _highScores
                               orderby s.Score descending
                               select s).ToList();
                RefreshHighScores();
            }
        }

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

        private void MoveHeadOfSnake()
        {
            switch (_currentDirection)
            {
                case DIRECTION.POSITIVE_X:
                    _head.X++;
                    _head.X %= DIMENSION;
                    break;
                case DIRECTION.POSITIVE_Y:
                    _head.Y++;
                    _head.Y %= DIMENSION;
                    break;
                case DIRECTION.POSITIVE_Z:
                    _head.Z++;
                    _head.Z %= DIMENSION;
                    break;
                case DIRECTION.NEGATIVE_X:
                    if (_head.X == 0)
                        _head.X = DIMENSION - 1;
                    else
                        _head.X--;
                    break;
                case DIRECTION.NEGATIVE_Y:
                    if (_head.Y == 0)
                        _head.Y = DIMENSION - 1;
                    else
                        _head.Y--;
                    break;
                case DIRECTION.NEGATIVE_Z:
                    if (_head.Z == 0)
                        _head.Z = DIMENSION - 1;
                    else
                        _head.Z--;
                    break;
                default:
                    break;
            }
        }

        public BindingList<string> RefreshHighScores()
        {
            _boundHighScores.Clear();
            foreach (var h in _highScores)
            {
                _boundHighScores.Add(h.ToString());
            }
            return _boundHighScores;
        }
        
        private bool CheckForCollision()
        {
            for (int i = 1; i < _snake.Count; i++)
            {
                if (_head == _snake[i])
                    return true;
            }
            return false;
        }
        
        public void ChangeCurrentDirection(Keys key)
        {
            switch (key)
            {
                case Keys.Left:
                case Keys.A:
                    switch(_currentDirection)
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
                    switch(_currentDirection)
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
                    switch(_currentDirection)
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

        private void WriteHighScores()
        {
            _streamWriter = new StreamWriter(AssetHandler._highScoreURL);
            foreach (var h in _highScores)
            {
                _streamWriter.WriteLine(h.Name + "," + h.Score);
            }
            _streamWriter.Close();
        }

        private void ReadHighScores()
        {
            string line;
            _streamReader = new StreamReader(AssetHandler._highScoreURL);
            while ((line = _streamReader.ReadLine()) != null) 
            {
                string[] tokens = line.Split(',');
                _highScores.Add(new HighScore(tokens[0], Convert.ToInt32(tokens[1])));
            }
            _streamReader.Close();
        }
                
        public bool[][] GetPlane()
        {
            return _cube.GetPlane(CubeController.Cube.AXIS.AXIS_Z, _currentPlane);
        }

        public string GetScore()
        {
            return _score.ToString();
        }
    }

    internal class SnakeSection
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public SnakeSection()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public SnakeSection(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void Reset()
        {
            X = 0;
            Y = 0;
            Z = 0;       
        }

        public static bool operator ==(SnakeSection a, SnakeSection b)
        {
            if (Object.ReferenceEquals(a,b))
                return true;
            if (((object)a == null) || ((object)b == null)) 
                return false;
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator !=(SnakeSection a, SnakeSection b)
        {
            return !(a == b);
        }
    }

    internal class HighScore
    {
        public string Name;
        public int Score;

        public HighScore(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public override string ToString()
        {
            return Name + ": " + Score.ToString();
        }        
    }
}
