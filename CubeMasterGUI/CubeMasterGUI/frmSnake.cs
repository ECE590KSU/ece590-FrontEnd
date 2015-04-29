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
    public partial class frmSnake : Form
    {
        private Snake _snakeController;

        private int _currentPlane;

        private Timer _refreshTimer;

        private int _voxelGrid_startX = 20;
        private int _voxelGrid_startY = 75;
        private int _voxelSpacing = 9;
        private int _voxelHeight = 80;
        private int _voxelWidth = 80;

        private Voxel[,] _voxels;

        private Color _clrVoxelClicked = AssetHandler._secondaryControlColor;
        private Color _clrVoxelUnclicked = AssetHandler._primaryFormColor;

        public frmSnake(ref CubeController.Cube cube, int parentWidth, int parentHeight)
        {
            InitializeComponent();

            _snakeController = new Snake(ref cube);
            _currentPlane = 0;

            this.Width = parentWidth;
            this.Height = parentHeight;

            GenerateVoxelGrid();
            InvokeTimerProtocol();

            _refreshTimer = new Timer();
            _refreshTimer.Interval = 1000 / 60; //roughly 60 fps
            _refreshTimer.Tick += new EventHandler(RefreshVoxelGrid);
            _refreshTimer.Start();


        }

        private void InvokeTimerProtocol()
        {
            if (!this.DesignMode)
            {
                this.tmrSnake.InitializeTimers();
            }
        }
                
        private void frmGames_MouseMove(object sender, MouseEventArgs e)
        {
            this.tmrSnake.ResetTimers();
        }

        private void frmGames_MouseClick(object sender, MouseEventArgs e)
        {
            this.tmrSnake.ResetTimers();
        }

        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            _snakeController.ChangeInputState(e.KeyCode);
        }

        private void frmSnake_KeyUp(object sender, KeyEventArgs e)
        {
            //_snakeController.ChangeInputState(e.KeyCode, false);
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
                    tmpVoxel.Left = _voxelGrid_startX + (i * _voxelWidth + _voxelSpacing);
                    tmpVoxel.Top = _voxelGrid_startY + ((7 - j) * _voxelHeight + _voxelSpacing);

                    tmpVoxel.X = j;
                    tmpVoxel.Y = i;

                    var lbl = new Label();
                    //lbl.Text = "[" + i + "," + j + "]";
                    tmpVoxel.Controls.Add(lbl);

                    tmpVoxel.BringToFront();
                    tmpVoxel.Cursor = Cursors.Cross;

                    /*tmpVoxel.MouseClick += frmFreeDraw_VoxelGridClick;
                    tmpVoxel.MouseDown += frmFreeDraw_MouseDown;
                    tmpVoxel.MouseUp += frmFreeDraw_MouseUp;
                    tmpVoxel.MouseMove += frmFreeDraw_MouseMove;*/

                    _voxels[j, i] = tmpVoxel;
                    this.Controls.Add(tmpVoxel);
                }
            }
        }

        public void RefreshVoxelGrid(object sender, EventArgs e)
        {
            this.SuspendLayout();
            var tmpplane = _snakeController.GetPlane(_currentPlane);

            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    _voxels[i, j].BackColor = tmpplane[i][j] ? _clrVoxelClicked : _clrVoxelUnclicked;
                }
            }
            this.ResumeLayout();
        }

        private void frmSnake_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Focus();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmSnake_KeyDown);
        }
    }

}
