﻿using System;
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

        private List<Button> _functions;

        private bool _isSecondClick = false;

        private System.Drawing.Point _drawStart;
        private System.Drawing.Point _drawEnd;

        private CubeController.Point _drawPointStart;
        private CubeController.Point _drawPointEnd;
        
        private int _voxelGrid_startX = 20;
        private int _voxelGrid_startY = 75;
        private int _voxelSpacing = 9;
        private int _voxelHeight = 80;
        private int _voxelWidth = 80;

        private Bitmap _imgOrientZ;
        private Bitmap _imgOrientY;
        private Bitmap _imgOrientX;

        private Voxel[,] _voxels;

        private Color _clrVoxelClicked = AssetHandler.BtnBackColor_Tertiary;
        private Color _clrVoxelUnclicked = AssetHandler.FormBackColor;

        private System.Windows.Forms.Timer _demoTimer;
        private System.Threading.Thread _demoThread;

        public frmFreeDraw(ref CubeController.Cube cube, int parentWidth, int parentHeight)
        {
            InitializeComponent();
            _freeDrawController = new FreeDraw(ref cube);
            _freeDrawController.SelectedPlane = (int)(this.uxPlaneSelect.Value - 1);

            this.Width = parentWidth;
            this.Height = parentHeight;

            GenerateVoxelGrid();
            AssignDrawingFunctions();
            InvokeTimerProtocol();
            SetButtonIcons();
            InitializeRadioButtons();
            SetupDemo();
            this.ShowInTaskbar = false;

            // Set up the initial index of the combo-box. 
            this.cmbReflection.SelectedIndex = 0;

            this.MouseWheel += new MouseEventHandler(this.uxPlaneSelect_MouseWheel);
        }

        private void SetButtonIcons()
        {
            this.btnRotateCW.Image = new Bitmap(AssetHandler.RotateCW_URL);
            this.btnRotateCCW.Image = new Bitmap(AssetHandler.RotateCCW_URL);
            this.btnCopy.Image = new Bitmap(AssetHandler.Copy);
            this.btnPaste.Image = new Bitmap(AssetHandler.Paste);
            this.btnDemo.Image = new Bitmap(AssetHandler.StartDemo);
            this.btnDemoStop.Image = new Bitmap(AssetHandler.StopDemo);

            _freeDrawController.AddDrawingImagesEntry(this.btnSingle, AssetHandler.DrawSingle, AssetHandler.DrawSingleAlt);
            _freeDrawController.AddDrawingImagesEntry(this.btnRectangle, AssetHandler.DrawRect, AssetHandler.DrawRectAlt);
            _freeDrawController.AddDrawingImagesEntry(this.btnCircle, AssetHandler.DrawCircle, AssetHandler.DrawCircleAlt);
            _freeDrawController.AddDrawingImagesEntry(this.btnLine, AssetHandler.DrawLine, AssetHandler.DrawLineAlt);
            ToggleSelectedDrawingFunction(this.btnSingle);

            _imgOrientX = new Bitmap(AssetHandler.OrientXURL);
            _imgOrientY = new Bitmap(AssetHandler.OrientYURL);
            _imgOrientZ = new Bitmap(AssetHandler.OrientZURL);
        }

        private void AssignDrawingFunctions()
        {
            _functions = new List<Button>();
            _functions.Add(this.btnSingle);
            _functions.Add(this.btnLine);
            _functions.Add(this.btnRectangle);
            _functions.Add(this.btnCircle);
        }

        private void InvokeTimerProtocol()
        {
            if (!this.DesignMode)
            {
                this.tmrFreeDraw.InitializeTimers();
            }
        }

        private void InitializeRadioButtons()
        {
            this.btnAXIS_Y.Checked = true;
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
                    tmpVoxel.Top = _voxelGrid_startY + ((7-j)*_voxelHeight + _voxelSpacing);
                    
                    tmpVoxel.X = j;
                    tmpVoxel.Y = i;

                    tmpVoxel.BringToFront();
                    tmpVoxel.Cursor = Cursors.Cross;

                    tmpVoxel.MouseClick += frmFreeDraw_VoxelGridClick;

                    _voxels[j, i] = tmpVoxel;
                    this.Controls.Add(tmpVoxel);
                }
            }
        }

        public void RefreshVoxelGrid()
        {
            this.SuspendLayout();
            var tmpplane = _freeDrawController.GetPlane((int)uxPlaneSelect.Value -1);

            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    _voxels[i, j].BackColor = tmpplane[i][j] ? _clrVoxelClicked : _clrVoxelUnclicked;
                }
            }
            this.ResumeLayout();
        }

        private void SetupDemo()
        {
            _demoTimer = new Timer();
            _demoTimer.Tick += Demo_TimerTick;
            _demoTimer.Interval = 100;
            _demoThread = new System.Threading.Thread(DemoThreadEntry);
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

            // SINGLE DRAW (POINT BY POINT)
            if (_freeDrawController.CurrentDrawingMode == FreeDraw.DRAWING_MODE.SINGLE)
            {
                _freeDrawController.SwapVoxel(vox.X, vox.Y);
            }

            // LINE DRAW (POINT TO POINT)
            else if (_freeDrawController.CurrentDrawingMode == FreeDraw.DRAWING_MODE.LINE)
            {
                if (!_isSecondClick)
                {
                    // Have to wait for two clicks in order for a line to be drawn. Indicate 
                    // that you are ready to accept a second click. 
                    _isSecondClick = true;
                    _drawStart = PointToClient(e.Location);
                    _drawPointStart = _freeDrawController.VoxelToPoint(sender as Voxel);
                    _freeDrawController.SetVoxel((sender as Voxel).X, (sender as Voxel).Y);
                }
                else
                {
                    // Reset for a new set of two clicks.
                    _isSecondClick = false;
                    _drawEnd = PointToClient(e.Location);
                    _drawPointEnd = _freeDrawController.VoxelToPoint(sender as Voxel);
                    _freeDrawController.SetVoxel((sender as Voxel).X, (sender as Voxel).Y);

                    // Actually draw the line
                    if (_drawPointStart != null && _drawPointEnd != null)
                    {
                        _freeDrawController.DrawLine(_drawPointStart, _drawPointEnd);
                    }
                }
            }
            
            // RECTANGLE DRAW
            else if (_freeDrawController.CurrentDrawingMode == FreeDraw.DRAWING_MODE.RECTANGLE)
            {
                if (!_isSecondClick)
                {
                    // Have to wait for two clicks in order for a rectangle to be drawn. Indicate 
                    // that you are ready to accept a second click. 
                    _isSecondClick = true;
                    _drawStart = PointToClient(e.Location);
                    _drawPointStart = _freeDrawController.VoxelToPoint(sender as Voxel);
                    // Feedback to the user, shows them the selected voxel. 
                    _freeDrawController.SetVoxel((sender as Voxel).X, (sender as Voxel).Y);
                }
                else
                {
                    // Reset for a new set of two clicks.
                    _isSecondClick = false;
                    _drawEnd = PointToClient(e.Location);
                    _drawPointEnd = _freeDrawController.VoxelToPoint(sender as Voxel);
                    // Feedback to the user, shows them the selected voxel. 
                    _freeDrawController.SetVoxel((sender as Voxel).X, (sender as Voxel).Y);

                    // Actually draw the rectangle
                    if (_drawPointStart != null && _drawPointEnd != null)
                    {
                        _freeDrawController.DrawRectangle(_drawPointStart, _drawPointEnd);
                    }
                }
            }

            // CIRCLE DRAW
            else
            {
                if (!_isSecondClick)
                {
                    // Have to wait for two clicks in order for a circle to be drawn. Indicate
                    // that you are ready to accept a second click.
                    _isSecondClick = true;
                    _drawStart = PointToClient(e.Location);
                    _drawPointStart = _freeDrawController.VoxelToPoint(sender as Voxel);
                    _freeDrawController.SetVoxel((sender as Voxel).X, (sender as Voxel).Y);
                }
                else
                {
                    // Reset for a new set of two clicks.
                    _isSecondClick = false;
                    _drawEnd = PointToClient(e.Location);
                    _drawPointEnd = _freeDrawController.VoxelToPoint(sender as Voxel);
                    // Shows them the selected voxel. 
                    _freeDrawController.SetVoxel((sender as Voxel).X, (sender as Voxel).Y);

                    // Actually draw the circle
                    if (_drawPointStart != null && _drawPointEnd != null)
                    {
                        // Clear out the points that you set for feedback, as they may not be a part
                        // of the final arc.
                        _freeDrawController.ClearVoxel(_drawPointStart);
                        _freeDrawController.ClearVoxel(_drawPointEnd);

                        _freeDrawController.DrawCircle(_drawPointStart, _drawPointEnd);
                    }
                }
            }

            RefreshVoxelGrid();
        }

        private void btnAXIS_X_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btnx = sender as RadioButton;
            if (btnx.Checked)
            {
                _freeDrawController.SelectedAxis = CubeController.Cube.AXIS.AXIS_X;
                this.picPreview.Image = _imgOrientX;
                RefreshVoxelGrid();
            }
        }

        private void btnAXIS_Y_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btny = sender as RadioButton;
            if (btny.Checked)
            {
                _freeDrawController.SelectedAxis = CubeController.Cube.AXIS.AXIS_Y;
                this.picPreview.Image = _imgOrientY;
                RefreshVoxelGrid();
            }
        }

        private void btnAXIS_Z_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btnz = sender as RadioButton;
            if (btnz.Checked)
            {
                _freeDrawController.SelectedAxis = CubeController.Cube.AXIS.AXIS_Z;
                this.picPreview.Image = _imgOrientZ;
                RefreshVoxelGrid();
            }
        }

        private void btnClearPlane_Click(object sender, EventArgs e)
        {
            _freeDrawController.ClearPlane(_freeDrawController.SelectedPlane);
            RefreshVoxelGrid();
        }

        private void btnFillPlane_Click(object sender, EventArgs e)
        {
            _freeDrawController.SetPlane(_freeDrawController.SelectedPlane);
            RefreshVoxelGrid();
        }

        private void uxPlaneSelect_ValueChanged(object sender, EventArgs e)
        {
            _freeDrawController.SelectedPlane = (int)(this.uxPlaneSelect.Value - 1);
            RefreshVoxelGrid();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            _freeDrawController.ClearEntireCube();
            this.uxPlaneSelect.Value = 1;
            RefreshVoxelGrid();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            // Only try and start the demo thread if it is not already alive!!
            if (!(_demoThread.IsAlive || _demoThread.IsBackground))
            {
                this.tmrFreeDraw.ResetTimers();
                _demoTimer.Start();
                _demoThread.Start();
            }
        }

        private void DemoThreadEntry()
        {
            _freeDrawController.Demo();
        }

        private void Demo_TimerTick(object sender, EventArgs e)
        {
            RefreshVoxelGrid();
        }

        private void btnDemoStop_Click(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            _demoTimer.Stop();
            _demoThread.Abort();
            _freeDrawController.ClearEntireCube();
            RefreshVoxelGrid();
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            _freeDrawController.CurrentDrawingMode = FreeDraw.DRAWING_MODE.SINGLE;
            _isSecondClick = false;
            ToggleSelectedDrawingFunction(sender as Button);
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            _freeDrawController.CurrentDrawingMode = FreeDraw.DRAWING_MODE.LINE;
            _isSecondClick = false;
            ToggleSelectedDrawingFunction(sender as Button);
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            _freeDrawController.CurrentDrawingMode = FreeDraw.DRAWING_MODE.RECTANGLE;
            _isSecondClick = false;
            ToggleSelectedDrawingFunction(sender as Button);
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            _freeDrawController.CurrentDrawingMode = FreeDraw.DRAWING_MODE.CIRCLE;
            _isSecondClick = false;
            ToggleSelectedDrawingFunction(sender as Button);
        }

        private void ToggleSelectedDrawingFunction(Button sender)
        {
            this.tmrFreeDraw.ResetTimers();
            bool isAlternate = false;
            foreach (Button b in _functions)
            {
                isAlternate = b.Equals(sender);
                _freeDrawController.SwapDrawingFunctionImg(b, isAlternate);
                b.BackColor = isAlternate ? AssetHandler.BtnBackColor_Secondary : AssetHandler.BtnBackColor_Primary;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            _freeDrawController.CopyPlane();
            RefreshVoxelGrid();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            _freeDrawController.PastePlane();
            RefreshVoxelGrid();
        }

        private void btnRotateCW_Click(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            _freeDrawController.Rotate(270);
            RefreshVoxelGrid();
        }

        private void btnRotateCCW_Click(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            _freeDrawController.Rotate(90);
            RefreshVoxelGrid();
        }

        private void btnMirrorX_Click(object sender, EventArgs e)
        {
            _freeDrawController.SymmetryX();
            RefreshVoxelGrid();
        }

        private void btnMirrorY_Click(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            _freeDrawController.SymmetryY();
            RefreshVoxelGrid();
        }

        private void btnMirrorZ_Click(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            _freeDrawController.SymmetryZ();
            RefreshVoxelGrid();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            string optionSelected = this.cmbReflection.SelectedItem.ToString();
            _freeDrawController.SetReflection(optionSelected);
        }

        private void btnShiftUp_Click(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            _freeDrawController.ShiftUp();
            RefreshVoxelGrid();
        }

        private void btnShiftDown_Click(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            _freeDrawController.ShiftDown();
            RefreshVoxelGrid();
        }

        /// <summary>
        /// Following: https://support.microsoft.com/en-us/kb/320584 to handle
        /// keystrokes, key-combos, and chords. 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            const int WM_KEYDOWN = 0x100;
            const int WM_SYSKEYDOWN = 0x104;

            if ((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN))
            {
                switch (keyData)
                {
                    // Copy
                    case Keys.Control | Keys.C:
                        this.btnCopy_Click(null, null);
                        break;
                    // Paste
                    case Keys.Control | Keys.V:
                        this.btnPaste_Click(null, null);
                        break;
                    // Clear Plane
                    case Keys.Control | Keys.X:
                        this.btnClearPlane_Click(null, null);
                        break;
                    // Clear All
                    case Keys.Control | Keys.Shift | Keys.X:
                        this.btnClearAll_Click(null, null);
                        break;
                    // Fill Plane
                    case Keys.Control | Keys.F:
                        this.btnFillPlane_Click(null, null);
                        break;
                    // Shift forward
                    case Keys.Control | Keys.Shift | Keys.Up:
                        this.btnShiftUp_Click(null, null);
                        break;
                    // Shift reverse
                    case Keys.Control | Keys.Shift | Keys.Down:
                        this.btnShiftDown_Click(null, null);
                        break;
                    // Draw Single
                    case Keys.Control | Keys.S:
                        this.btnSingle_Click(this.btnSingle, null);
                        break;
                    // Draw Line
                    case Keys.Control | Keys.L:
                        this.btnLine_Click(this.btnLine, null);
                        break;
                    // Draw Rectangle
                    case Keys.Control | Keys.R:
                        this.btnRectangle_Click(this.btnRectangle, null);
                        break;
                    // Draw Circle
                    case Keys.Control | Keys.O:
                        this.btnCircle_Click(this.btnCircle, null);
                        break;
                    default:
                        break;
                }
                
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void uxPlaneSelect_MouseWheel(object sender, MouseEventArgs me)
        {
            if (me.Delta > 0)
            {
                this.uxPlaneSelect.UpButton();
            }
            else
            {
                this.uxPlaneSelect.DownButton();
            }
        }

        private void btnAXIS_X_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Left ||
                e.KeyCode == System.Windows.Forms.Keys.Right ||
                e.KeyCode == System.Windows.Forms.Keys.Up ||
                e.KeyCode == System.Windows.Forms.Keys.Down)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
