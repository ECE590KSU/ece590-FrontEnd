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
    public partial class btnAppLauncher : UserControl
    {
        public btnAppLauncher()
        {
            InitializeComponent();
        }

        public void SetBackground(string path)
        {
            this.picBkgd.Image = new Bitmap(path);
        }
    }
}
