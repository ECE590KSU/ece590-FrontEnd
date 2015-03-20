using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeMasterGUI
{
    public partial class frmStartScreen : Form
    {
        private StartScreen _startScreenController;

        public frmStartScreen()
        {
            InitializeComponent();
            _startScreenController = new StartScreen();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            _startScreenController.Launch_MainMenu();
        }
    }
}
