using System;
using System.Collections;
using System.Collections.Generic;
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

        private enum DIRECTION { POSITIVE_X, POSITIVE_Y, NEGATIVE_X, NEGATIVE_Y };
        private enum DIFFICULTY { EASY, MEDIUM, HARD };

        private DIRECTION _currentDirection;
        private Timer _gameTimer;

        private SnakeSection _head;
        private List<SnakeSection> _snake;

        private Random _random;

        private int _tickCount = 0;

        public Snake(ref CubeController.Cube cube)
        {
            _cube = cube;
            _currentDirection = DIRECTION.NEGATIVE_X;

            _head = new SnakeSection();
            _cube.SwapVoxel(_head.X, _head.Y, 0);

            _snake = new List<SnakeSection>();
            _snake.Add(_head);

            _random = new Random();

            _difficultyDictionary = new Dictionary<string, DIFFICULTY>
            {
                {"btnEasy", DIFFICULTY.EASY},
                {"btnMedium", DIFFICULTY.MEDIUM},
                {"btnHard", DIFFICULTY.HARD}
            };

            _gameTimer = new Timer();
            _gameTimer.Interval = 750;
            _gameTimer.Tick += GameTimerTick;
            _gameTimer.Start();

            SpawnFood();
        }

        private void SpawnFood()
        {
            int x = -1, y = -1;
            bool valid = false;
            while (!valid)
            {
                x = _random.Next(DIMENSION);
                y = _random.Next(DIMENSION);
                valid = true;
                foreach (var s in _snake)
                {
                    if (x == s.X || y == s.Y)
                        valid = false;
                }
            }

            _cube.SwapVoxel(x, y, 0);

        }

        public void ChangeDifficultySetting(string s)
        {
            _gameTimer.Stop();
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
            _gameTimer.Start();
        }

        private void GameTimerTick(object sender, EventArgs e)
        {
            _tickCount++;
            if (_tickCount % 2 == 0)
            {
                var temp = new SnakeSection(_head.X, _head.Y);
                _snake.Add(temp);
            }
            _cube.SwapVoxel(_head.X, _head.Y, 0);
            switch(_currentDirection)
            {
                case DIRECTION.POSITIVE_X:
                    _head.X++;
                    _head.X %= DIMENSION; 
                    break;
                case DIRECTION.POSITIVE_Y:
                    _head.Y++;
                    _head.Y %= DIMENSION;
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
                default:
                    break;
            }
            _cube.SwapVoxel(_head.X, _head.Y, 0);
        }

        private void DisplaySnake()
        {
            foreach (var s in _snake)
            {

            }
        }
        
        public void ChangeInputState(Keys key)
        {
            switch (key)
            {
                case Keys.Left:
                    if (_currentDirection == DIRECTION.NEGATIVE_Y)
                        _currentDirection = DIRECTION.POSITIVE_X;
                    else
                        _currentDirection++;
                    break;
                case Keys.Right:
                    if (_currentDirection == DIRECTION.POSITIVE_X)
                        _currentDirection = DIRECTION.NEGATIVE_Y;
                    else
                        _currentDirection--;
                    break;
                default:
                    break;
            }
        }
                
        public bool[][] GetPlane(int plane)
        {
            return _cube.GetPlane(CubeController.Cube.AXIS.AXIS_Z, plane);
        }
    }

    internal class SnakeSection
    {
        public int X { get; set; }
        public int Y { get; set; }

        public SnakeSection()
        {
            X = 0;
            Y = 0;
        }

        public SnakeSection(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
