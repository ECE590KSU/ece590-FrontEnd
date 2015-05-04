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

        private Timer _refreshTimer;

        private int _voxelGrid_startX = 278;
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

            this.Width = parentWidth;
            this.Height = parentHeight;

            GenerateVoxelGrid();
            InvokeTimerProtocol();

            btnMedium.Checked = true;
            _snakeController.ChangeDifficultySetting(btnMedium.Name);

            btnEasy.CheckedChanged += DifficultyChanged;
            btnMedium.CheckedChanged += DifficultyChanged;
            btnHard.CheckedChanged += DifficultyChanged;

            _refreshTimer = new Timer();
            _refreshTimer.Interval = 1000 / 60; //roughly 60 fps
            _refreshTimer.Tick += new EventHandler(RefreshVoxelGrid);
            _refreshTimer.Start();
        }

        private void DifficultyChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            if (btn.Checked)
            {
                _snakeController.ChangeDifficultySetting(btn.Name);
            }
            this.Focus();
        }

        private void InvokeTimerProtocol()
        {
            if (!this.DesignMode)
            {
                this.tmrSnake.InitializeTimers();
            }
        }
        
        private void frmSnake_KeyUp(object sender, KeyEventArgs e)
        {
            _snakeController.ChangeCurrentDirection(e.KeyCode);
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

                    tmpVoxel.BringToFront();;
                    
                    _voxels[j, i] = tmpVoxel;
                    this.Controls.Add(tmpVoxel);
                }
            }
        }

        public void RefreshVoxelGrid(object sender, EventArgs e)
        {
            this.SuspendLayout();
            var tmpplane = _snakeController.GetPlane();

            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    _voxels[i, j].BackColor = tmpplane[i][j] ? _clrVoxelClicked : _clrVoxelUnclicked;
                }
            }
            this.ResumeLayout();
            lblScore.Text = "Score: " + _snakeController.GetScore();
        }

        private void frmSnake_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Focus();
            this.KeyPreview = true;
            this.PreviewKeyDown += new PreviewKeyDownEventHandler(frmSnake_PreviewKeyDown);

            listBoxHighScores.DataSource = _snakeController.RefreshHighScores();
        }
                
        private void frmSnake_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                    e.IsInputKey = true;
                    break;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnEasy.Checked)
                _snakeController.ChangeDifficultySetting(btnEasy.Name);
            else if (btnMedium.Checked)
                _snakeController.ChangeDifficultySetting(btnMedium.Name);
            else if (btnHard.Checked)
                _snakeController.ChangeDifficultySetting(btnHard.Name);

            tmrSnake.ChangeInactiveTimeout(180);
            _snakeController.StartNewGame();
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            _snakeController.EndGame();
        }
        
        private void btnEasy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Right
                )
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btnMedium_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Right
                )
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btnHard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Right
                )
            {
                e.SuppressKeyPress = true;
            }
        }

        private void frmSnake_MouseMove(object sender, MouseEventArgs e)
        {
            tmrSnake.ResetTimers();
        }
    }
}
