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
    public partial class S : Form
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

        public S(ref CubeController.Cube cube, int parentWidth, int parentHeight)
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

            lblScore.Location = new Point(1019, 527);
        }

        private void DifficultyChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            if (btn.Checked)
            {
                _snakeController.ChangeDifficultySetting(btn.Name);
            }
        }

        private void InvokeTimerProtocol()
        {
            if (!this.DesignMode)
            {
                this.tmrSnake.InitializeTimers();
            }
        }
        
        // reset snake timer

        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            //_snakeController.ChangeInputState(e.KeyCode);
        }

        private void frmSnake_KeyUp(object sender, KeyEventArgs e)
        {
            _snakeController.ChangeInputState(e.KeyCode);
            tmrSnake.ResetText();
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
            this.KeyDown += new KeyEventHandler(frmSnake_KeyDown);
            this.PreviewKeyDown += new PreviewKeyDownEventHandler(frmSnake_PreviewKeyDown);
        }

        private void frmSnake_MouseClick(object sender, MouseEventArgs e)
        {
            _snakeController.ChangeInputState(Keys.Left);
            tmrSnake.ResetTimers();
        }

        private void frmSnake_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //_snakeController.ChangeInputState(Keys.Right);
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

            _snakeController.StartNewGame();
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            _snakeController.EndGame();
        }

        //protected override bool IsInputKey(Keys keyData)
        //{
        //    switch (keyData)
        //    {
        //        case Keys.Right:
        //        case Keys.Left:
        //        case Keys.Up:
        //        case Keys.Down:
        //            return true;
        //    }
        //    return base.IsInputKey(keyData);
        //}

        //protected override void OnKeyDown(KeyEventArgs e)
        //{
        //    base.OnKeyDown(e);
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Right:
        //        case Keys.Left:
        //        case Keys.Up:
        //        case Keys.Down:
        //            _snakeController.ChangeInputState(e.KeyCode);
        //            break;
        //    }
        //}
    }

}
