using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace CubeMasterGUI
{
    public partial class AppLauncher : UserControl
    {
        public AppLauncher()
        {
            InitializeComponent();
        }

        public void SetBkgdImage(string path)
        {
            this.btnLaunch.Image = new Bitmap(path);
        }

        private void btnLaunch_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnLaunch_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
