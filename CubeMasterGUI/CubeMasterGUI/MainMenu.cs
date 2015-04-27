using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeMasterGUI
{
    public class MainMenu
    {
        private StartScreen _startScreenParent;


        public MainMenu(ref StartScreen startScreenParent)
        {
            _startScreenParent = startScreenParent;
        }

        internal void ApplicationLaunch_Text2Cube()
        {

        }

        internal void ApplicationLaunch_FreeDraw()
        {
            CubeController.Cube rootCubeController = _startScreenParent.GetRootCubeController();
            frmFreeDraw freeDraw = new frmFreeDraw(ref rootCubeController, _startScreenParent.ParentScreenWidth, _startScreenParent.ParentScreenHeight);

            if (freeDraw.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        internal void ApplicationLaunch_AudioVisual()
        {

        }

        internal void ApplicationLaunch_Games()
        {
            CubeController.Cube rootCubeController = _startScreenParent.GetRootCubeController();
            frmSnake snake = new frmSnake(ref rootCubeController, _startScreenParent.ParentScreenWidth, _startScreenParent.ParentScreenHeight);

            if (snake.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        internal void ApplicationLaunch_Presets()
        {

        }
    }
}
