using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeMasterGUI
{
    public class MainMenu
    {
        private StartScreeen _startScreenParent { get; set; }

        public MainMenu(ref StartScreeen startScreenParent)
        {

        }

        internal void ApplicationLaunch_Text2Cube()
        {

        }

        internal void ApplicationLaunch_FreeDraw()
        {
            CubeController rootCubeController = _startScreenParent.GetRootCubeController();
            frmFreeDraw freeDraw = new frmFreeDraw(ref rootCubeController);

            if (freeDraw.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        internal void ApplicationLaunch_AudioVisual()
        {

        }

        internal void ApplicationLaunch_Games()
        {

        }

        internal void ApplicationLaunch_Presets()
        {

        }
    }
}
