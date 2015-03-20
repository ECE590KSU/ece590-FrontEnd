using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CubeMasterGUI
{
    public class StartScreen
    {
        private CubeController _rootCubeController;

        public StartScreen()
        {
            _rootCubeController = new CubeController();
        }

        public CubeController GetRootCubeController()
        {
            return _rootCubeController;
        }

        public void Launch_MainMenu()
        {
            frmMainMenu mainMenu = new frmMainMenu(this);
            if (mainMenu.ShowDialog() == DialogResult.Cancel)
            {

            }
        }
    }
}
