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
    public partial class frmFreeDraw : Form
    {
        private FreeDraw _freeDrawController;
        
        public frmFreeDraw(ref CubeController cube)
        {
            InitializeComponent();
            _freeDrawController = new FreeDraw(ref cube);
        }
    }
}
