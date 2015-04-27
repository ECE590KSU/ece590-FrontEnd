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
        private CubeController.Cube _cube;

        private Hashtable _keys;

        int _x;

        int _y;
                
        public Snake(ref CubeController.Cube cube)
        {
            _cube = cube;
            _keys = new Hashtable();
            _x = 250;
            _x = 250;
        }

        public void GameTickHandler()
        {
            if (IsPressed(Keys.Right))
                _x += 4;
            if (IsPressed(Keys.Left))
                _x -= 4;
            if (IsPressed(Keys.Up))
                _y-= 4;
            if (IsPressed(Keys.Down))
                _y += 4;
        }

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
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
