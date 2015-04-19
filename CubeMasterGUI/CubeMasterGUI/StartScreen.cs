﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CubeController;

namespace CubeMasterGUI
{
    public class StartScreen
    {
        private CubeController.Cube _rootCubeController;

        public StartScreen()
        {
            _rootCubeController = new CubeController.Cube();
        }

        public CubeController.Cube GetRootCubeController()
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