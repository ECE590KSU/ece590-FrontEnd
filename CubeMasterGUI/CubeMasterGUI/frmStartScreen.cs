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
        private CubeController _rootCubeController { get; set; }

        public frmStartScreen()
        {
            InitializeComponent();
            InitalizeCubeController();
        }

        public CubeController GetRootCubeController()
        {
            return this._rootCubeController;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            if (mainMenu.ShowDialog() == DialogResult.Cancel)
            {

            }
        }

        private void InitalizeCubeController()
        {
            this._rootCubeController = new CubeController();
        }

    }
}
