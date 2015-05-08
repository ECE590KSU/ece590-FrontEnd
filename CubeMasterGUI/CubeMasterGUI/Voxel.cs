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
        /// <summary>
        /// The 2D X coordinate of this current Voxel control.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// The 2D Y coordinate of this current Voxel control.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Able to check if this voxel is set or not.
        /// </summary>
        public bool VoxelSet { get; set; }

        /// <summary>
        /// Creates a new Voxel control.
        /// </summary>
        public Voxel()
        {
            InitializeComponent();
        }
    }
}
