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
    public partial class frmCatcher : Form
    {
        /// <summary>
        /// Controller for Catcher form
        /// </summary>
        private Catcher _catcherController;

        /// <summary>
        /// Timer that determines refresh rate of the graphics
        /// </summary>
        private Timer _refreshTimer;

        /// <summary>
        /// X-Coordinate where the voxel grid begins
        /// </summary>
        private int _voxelGrid_startX = 278;

        /// <summary>
        /// Y-Coordinate where the voxel grid begins
        /// </summary>
        private int _voxelGrid_startY = 75;

        /// <summary>
        /// Space between voxels in pixels
        /// </summary>
        private int _voxelSpacing = 9;

        /// <summary>
        /// Heigh of individual voxel
        /// </summary>
        private int _voxelHeight = 80;

        /// <summary>
        /// Width of individual voxel
        /// </summary>
        private int _voxelWidth = 80;

        /// <summary>
        /// Array storing the voxel controls
        /// </summary>
        private Voxel[,] _voxels;

        /// <summary>
        /// Color of a "clicked" voxel
        /// </summary>
        private Color _clrVoxelClicked = AssetHandler._secondaryControlColor;

        /// <summary>
        /// Color of an "unclicked" voxel
        /// </summary>
        private Color _clrVoxelUnclicked = AssetHandler._primaryFormColor;

        /// <summary>
        /// Constructor for frmCatcher
        /// </summary>
        /// <param name="cube">Reference to the cube controller</param>
        /// <param name="parentWidth">Width of the parent form</param>
        /// <param name="parentHeight">Heigh of the parent form</param>
        public frmCatcher(ref CubeController.Cube cube, int parentWidth, int parentHeight)
        {
            InitializeComponent();

            _catcherController = new Catcher(ref cube);

            this.Width = parentWidth;
            this.Height = parentHeight;

            GenerateVoxelGrid();
            InvokeTimerProtocol();

            btnMedium.Checked = true;
            _catcherController.ChangeDifficultySetting(btnMedium.Name);

            btnEasy.CheckedChanged += DifficultyChanged;
            btnEasy.KeyDown += SuppressKeyDown;
            btnMedium.CheckedChanged += DifficultyChanged;
            btnEasy.KeyDown += SuppressKeyDown;
            btnHard.CheckedChanged += DifficultyChanged;
            btnEasy.KeyDown += SuppressKeyDown;

            _refreshTimer = new Timer();
            _refreshTimer.Interval = 1000 / 60; //roughly 60 fps
            _refreshTimer.Tick += new EventHandler(RefreshVoxelGrid);
            _refreshTimer.Start();
        }

        /// <summary>
        /// Event handler for when the selected difficulty has changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DifficultyChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            if (btn.Checked)
            {
                _catcherController.ChangeDifficultySetting(btn.Name);
            }
            this.Focus();
        }

        /// <summary>
        /// Starts the timeout timer
        /// </summary>
        private void InvokeTimerProtocol()
        {
            if (!this.DesignMode)
            {
                this.tmrCatcher.InitializeTimers();
            }
        }
        
        /// <summary>
        /// Event handler for a KeyUp event to change the direction of the snake
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCatcher_KeyUp(object sender, KeyEventArgs e)
        {
            //_catcherController.ChangeCurrentDirection(e.KeyCode);
        }

        /// <summary>
        /// Generates the voxel grid on the form
        /// </summary>
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

        /// <summary>
        /// Refreshed the voxel grid on the Tick event of the refreshTimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RefreshVoxelGrid(object sender, EventArgs e)
        {
            this.SuspendLayout();
            var tmpplane = _catcherController.GetPlane();

            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    _voxels[i, j].BackColor = tmpplane[i][j] ? _clrVoxelClicked : _clrVoxelUnclicked;
                }
            }
            this.ResumeLayout();
            lblScore.Text = "Score: " + _catcherController.GetScore();
        }

        /// <summary>
        /// Event handler for loading the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCatcher_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Focus();
            this.KeyPreview = true;
            this.PreviewKeyDown += new PreviewKeyDownEventHandler(frmCatcher_PreviewKeyDown);
            listBoxHighScores.DataSource = _catcherController.RefreshHighScores();
        }
        
        /// <summary>
        /// Overload that makes the arrow keys input keys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCatcher_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        /// <summary>
        /// Event handler to start a new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnEasy.Checked)
                _catcherController.ChangeDifficultySetting(btnEasy.Name);
            else if (btnMedium.Checked)
                _catcherController.ChangeDifficultySetting(btnMedium.Name);
            else if (btnHard.Checked)
                _catcherController.ChangeDifficultySetting(btnHard.Name);

            tmrCatcher.ChangeInactiveTimeout(180);
            _catcherController.StartNewGame();
        }

        /// <summary>
        /// Event handler to end a game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEndGame_Click(object sender, EventArgs e)
        {
            _catcherController.EndGame();
        }
        
        /// <summary>
        /// Supress arrow KeyDown for the difficulty selection radio buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuppressKeyDown(object sender, KeyEventArgs e)
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

        /// <summary>
        /// Reset timers on a MouseMove Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCatcher_MouseMove(object sender, MouseEventArgs e)
        {
            tmrCatcher.ResetTimers();
        }
    }
}
