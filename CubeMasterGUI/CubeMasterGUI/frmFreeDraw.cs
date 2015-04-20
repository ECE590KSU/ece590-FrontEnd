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
        
        private int _voxelGrid_startX = 15;
        private int _voxelGrid_startY = 52;
        private int _voxelSpacing = 9;
        private int _voxelHeight = 80;
        private int _voxelWidth = 80;
        
        private Voxel[,] _voxels;

        private Color _clrVoxelClicked = Color.LightBlue;
        private Color _clrVoxelUnclicked = Color.GhostWhite;

        public frmFreeDraw(ref CubeController.Cube cube)
        {
            InitializeComponent();
            _freeDrawController = new FreeDraw(ref cube);
            GenerateVoxelGrid();
            InvokeTimerProtocol();
            CheckDefaultRadio();
        }

        private void InvokeTimerProtocol()
        {
            if (!this.DesignMode)
            {
                this.tmrFreeDraw.InitializeTimers();
            }
        }

        private void CheckDefaultRadio()
        {
            this.btnAXIS_X.Checked = true;
        }

        private void GenerateVoxelGrid()
        {
            _voxels = new Voxel[8, 8];

            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    Voxel tmpVoxel = new Voxel();
                    tmpVoxel.Height = _voxelHeight;
                    tmpVoxel.Width = _voxelWidth;
                    tmpVoxel.Left = _voxelGrid_startX + (i*_voxelWidth + _voxelSpacing);
                    tmpVoxel.Top = _voxelGrid_startY + (j*_voxelHeight + _voxelSpacing);
                    
                    tmpVoxel.X = i;
                    tmpVoxel.Y = j;

                    tmpVoxel.BringToFront();

                    tmpVoxel.MouseClick += frmFreeDraw_VoxelGridClick;

                    _voxels[i, j] = tmpVoxel;
                    this.Controls.Add(tmpVoxel);
                }
            }
        }

        private void frmFreeDraw_MouseMove(object sender, MouseEventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
        }

        private void frmFreeDraw_MouseClick(object sender, MouseEventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
        }

        private void frmFreeDraw_VoxelGridClick(object sender, MouseEventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            Voxel vox = sender as Voxel;
            vox.VoxelSet = !vox.VoxelSet;
            _voxels[vox.X, vox.Y].BackColor = vox.VoxelSet ? _clrVoxelClicked : _clrVoxelUnclicked;
        }
    }
}
