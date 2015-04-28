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
        public int ParentScreenHeight { get; set; }
        public int ParentScreenWidth { get; set; }

        public frmStartScreen()
        {
            InitializeComponent();
            ParentScreenHeight = 768;
            ParentScreenWidth = 1366;
            this.Height = ParentScreenHeight;
            this.Width = ParentScreenWidth;

            _startScreenController = new StartScreen(this.ParentScreenWidth, this.ParentScreenHeight);
            this.ShowInTaskbar = false;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            _startScreenController.Launch_MainMenu();
        }
    }
}
