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
            CubeController.Cube rootCubeController = _startScreenParent.GetRootCubeController();
            frmTextToCube text2Cube = new frmTextToCube(ref rootCubeController, _startScreenParent.ParentScreenWidth, _startScreenParent.ParentScreenHeight );

            if (text2Cube.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
            
            }
        }

        internal void ApplicationLaunch_FreeDraw()
        {
            CubeController.Cube rootCubeController = _startScreenParent.GetRootCubeController();
            frmFreeDraw freeDraw = new frmFreeDraw(ref rootCubeController, _startScreenParent.ParentScreenWidth, _startScreenParent.ParentScreenHeight);

            if (freeDraw.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        internal void ApplicationLaunch_Games()
        {

        }

        internal void ApplicationLaunch_Presets()
        {
            CubeController.Cube rootCubeController = _startScreenParent.GetRootCubeController();
            frmPresets presets = new frmPresets(ref rootCubeController, _startScreenParent.ParentScreenWidth, _startScreenParent.ParentScreenHeight);

            if (presets.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }
    }
}
