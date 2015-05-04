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
    public partial class frmPresets : Form
    {
        private Presets _presetsController;

        public frmPresets(ref CubeController.Cube cube, int parentWidth, int parentHeight)
        {
            InitializeComponent();
            _presetsController = new Presets(ref cube);

            this.ShowInTaskbar = false;
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            _presetsController.UpdateDelay(trackBarSpeed.Value);
        }
    }
}
