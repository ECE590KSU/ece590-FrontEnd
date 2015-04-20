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
    public partial class Voxel : UserControl
    {
        public int X { get; set; }
        public int Y { get; set; }

        public bool VoxelSet { get; set; }

        public Voxel()
        {
            InitializeComponent();
        }
    }
}
