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
        private CubeController _freeDrawCubeController { get; set; }
        
        public frmFreeDraw(ref CubeController cube)
        {
            InitializeComponent();
            _freeDrawCubeController = cube;
        }
    }
}
