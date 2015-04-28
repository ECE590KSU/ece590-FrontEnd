using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeMasterGUI
{
    public class Games
    {
        private CubeController.Cube _cube;

        public Games(ref CubeController.Cube cube)
        {
            _cube = cube;
        }

        public void LaunchSnake(int width, int height)
        {
            frmSnake snake = new frmSnake(ref _cube, width, height);

            if (snake.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }
    }
}
