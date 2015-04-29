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

        private enum DIRECTION { POSITIVE_X, POSITIVE_Y, NEGATIVE_X, NEGATIVE_Y };

        private DIRECTION _currentDirection;
        private Timer _gameTimer;
        private Hashtable _keys;

        private SnakeSection _head;
        private List<SnakeSection> _snake;

        private int _tickCount = 0;

        public Snake(ref CubeController.Cube cube)
        {
            _cube = cube;
            _keys = new Hashtable();
            _currentDirection = DIRECTION.NEGATIVE_X;

            _head = new SnakeSection();
            _cube.SwapVoxel(_head.X, _head.Y, 0);

            _snake = new List<SnakeSection>();
            _snake.Add(_head);

            _gameTimer = new Timer();
            _gameTimer.Interval = 750;
            _gameTimer.Tick += GameTimerTick;
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
                    _currentDirection++;
                    break;
                case Keys.Right:
                    _currentDirection--;
                    break;
                default:
                    break;
            }
        }

        public bool IsPressed(Keys key)
        {
            if (_keys[key] == null)
            {
                return false;
            }
            return (bool)_keys[key];
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
