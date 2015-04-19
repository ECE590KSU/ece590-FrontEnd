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
        private int _voxelGrid_startX = 30;
        private int _voxelGrid_startY = 30;
        private int _voxelSpacing = 15;
        private int _voxelHeight = 80;
        private int _voxelWidth = 80;

        private List<Button> _voxels;

        public frmFreeDraw(ref CubeController.Cube cube)
        {
            InitializeComponent();
            _freeDrawController = new FreeDraw(ref cube);
            GenerateVoxelGrid();
        }

        private void GenerateVoxelGrid()
        {
            _voxels = new List<Button>();

            for (int i = 0; i < 8; ++i){
                for (int j = 0; j < 8; ++j){
                    Button tmpVoxel = new Button();
                    tmpVoxel.Left = _voxelGrid_startX + (i*_voxelWidth + _voxelSpacing);
                    tmpVoxel.Top = _voxelGrid_startY + (j*_voxelHeight + _voxelSpacing);
                    
                    _voxels.Add(tmpVoxel);
                    this.Controls.Add(tmpVoxel);
                }
            }
        }

    }
}
