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
        private int FloatDistance = 20;
        private bool HasFloated = false;

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
            if (!HasFloated)
            {
                int i = 0;
                while (i++ < FloatDistance)
                {
                    this.Top--;
                }
                HasFloated = true;
            }
        }

        private void btnLaunch_MouseLeave(object sender, EventArgs e)
        {
            if (HasFloated)
            {
                int i = 0;
                while (i++ < FloatDistance)
                {
                    this.Top++;
                }
                HasFloated = false;
            }
        }
    }
}
