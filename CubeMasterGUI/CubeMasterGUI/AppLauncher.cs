using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
