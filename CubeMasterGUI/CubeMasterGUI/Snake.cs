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

                
        public Snake(ref CubeController.Cube cube)
        {
            _cube = cube;
            _keys = new Hashtable();
            _currentDirection = DIRECTION.POSITIVE_X;

            _head = new SnakeSection();
            _cube.SwapVoxel(_head.X, _head.Y, 0);

            _gameTimer = new Timer();
            _gameTimer.Interval = 750;
            _gameTimer.Tick += GameTimerTick;
            _gameTimer.Start();
        }

        private void GameTimerTick(object sender, EventArgs e)
        {
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
                    _head.X = (_head.X == 0) ? DIMENSION - 1 : _head.X--;
                    break;
                case DIRECTION.NEGATIVE_Y:
                    _head.Y = (_head.Y == 0) ? DIMENSION - 1 : _head.Y--;
                    break;
            }
            _cube.SwapVoxel(_head.X, _head.Y, 0);

        }
        
        public void ChangeInputState(Keys key, bool state)
        {
            _keys[key] = state;
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
    }
}
