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
        
        private int _voxelGrid_startX = 10;
        private int _voxelGrid_startY = 10;
        private int _voxelSpacing = 15;
        private int _voxelHeight = 80;
        private int _voxelWidth = 80;
        
        private Button[,] _voxels;

        private Color _clrVoxelClicked = Color.LightBlue;
        private Color _clrVoxelUnclicked = Color.GhostWhite;

        public frmFreeDraw(ref CubeController.Cube cube)
        {
            InitializeComponent();
            _freeDrawController = new FreeDraw(ref cube);
            GenerateVoxelGrid();
            InvokeTimerProtocol();
        }

        private void InvokeTimerProtocol()
        {
            if (!this.DesignMode)
            {
                this.tmrFreeDraw.InitializeTimers();
            }
        }

        private void GenerateVoxelGrid()
        {
            _voxels = new Button[8, 8];

            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    Button tmpVoxel = new Button();
                    tmpVoxel.Height = _voxelHeight;
                    tmpVoxel.Width = _voxelWidth;
                    tmpVoxel.Left = _voxelGrid_startX + (i*_voxelWidth + _voxelSpacing);
                    tmpVoxel.Top = _voxelGrid_startY + (j*_voxelHeight + _voxelSpacing);
                    tmpVoxel.Text = (i + "," + j);
                    tmpVoxel.Name = (i + "," + j);

                    tmpVoxel.MouseClick += frmFreeDraw_ButtonGridClick;

                    _voxels[i, j] = tmpVoxel;
                    this.Controls.Add(tmpVoxel);
                }
            }
        }

        private void frmFreeDraw_MouseMove(object sender, MouseEventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
        }

        private Tuple<int, int> ArrayCoordinatesOf(Button button, Button[,] voxels)
        {
            int w = voxels.GetLength(0);
            int h = voxels.GetLength(1);

            for (int x = 0; x < w; ++x)
            {
                for (int y = 0; y < h; ++y)
                {
                    if (voxels[x, y].Name.Equals(button.Name, StringComparison.Ordinal))
                    {
                        return new Tuple<int, int>(x, y);
                    }
                }
            }

            return null;
        }

        private void frmFreeDraw_MouseClick(object sender, MouseEventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
        }

        private void frmFreeDraw_ButtonGridClick(object sender, MouseEventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            Button voxelClicked = sender as Button;
            var coords = ArrayCoordinatesOf(voxelClicked, _voxels);

            _voxels[coords.Item1, coords.Item2].BackColor = 
                (_voxels[coords.Item1, coords.Item2].BackColor == _clrVoxelClicked) ? 
                _clrVoxelUnclicked : _clrVoxelClicked;
        }
    }
}
