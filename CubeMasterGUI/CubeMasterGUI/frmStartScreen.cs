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
        private StartScreeen _startScreenController;

        public frmStartScreen()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu(ref _startScreenController);
            if (mainMenu.ShowDialog() == DialogResult.Cancel)
            {

            }
        }
    }
}
