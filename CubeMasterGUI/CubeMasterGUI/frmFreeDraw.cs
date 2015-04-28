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

        private List<Button> _functions;

        private bool _isDragging = false;
        private System.Drawing.Point _drawStart;
        private System.Drawing.Point _drawEnd;
        private Voxel _drawVoxelStart;
        private Voxel _drawVoxelEnd;
        private int _voxelGrid_startX = 20;
        private int _voxelGrid_startY = 75;
        private int _voxelSpacing = 9;
        private int _voxelHeight = 80;
        private int _voxelWidth = 80;
        
        private Voxel[,] _voxels;

        private Color _clrVoxelClicked = AssetHandler._secondaryControlColor;
        private Color _clrVoxelUnclicked = AssetHandler._primaryFormColor;

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
            InitializeRadioButtons();
            SetupDemo();
            this.ShowInTaskbar = false;
        }

        private void AssignDrawingFunctions()
        {
            _functions = new List<Button>();
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
                    tmpVoxel.Top = _voxelGrid_startY + ((7-j)*_voxelHeight + _voxelSpacing);
                    
                    tmpVoxel.X = i;
                    tmpVoxel.Y = j;

                    var lbl = new Label();
                    lbl.Text = "[" + i + "," + j + "]";
                    tmpVoxel.Controls.Add(lbl);

                    tmpVoxel.BringToFront();
                    tmpVoxel.Cursor = Cursors.Cross;

                    tmpVoxel.MouseClick += frmFreeDraw_VoxelGridClick;
                    tmpVoxel.MouseDown += frmFreeDraw_MouseDown;
                    tmpVoxel.MouseUp += frmFreeDraw_MouseUp;
                    tmpVoxel.MouseMove += frmFreeDraw_MouseMove;

                    _voxels[i, j] = tmpVoxel;
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

            if (_freeDrawController.CurrentDrawingMode == FreeDraw.DRAWING_MODE.SINGLE)
            {
                _freeDrawController.SwapVoxel(vox.X, vox.Y);
            }

            RefreshVoxelGrid();
        }

        private void btnAXIS_X_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btnx = sender as RadioButton;
            if (btnx.Checked)
            {
                _freeDrawController.SelectedAxis = CubeController.Cube.AXIS.AXIS_X;
                RefreshVoxelGrid();
            }
        }

        private void btnAXIS_Y_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btny = sender as RadioButton;
            if (btny.Checked)
            {
                _freeDrawController.SelectedAxis = CubeController.Cube.AXIS.AXIS_Y;
                RefreshVoxelGrid();
            }
        }

        private void btnAXIS_Z_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btnz = sender as RadioButton;
            if (btnz.Checked)
            {
                _freeDrawController.SelectedAxis = CubeController.Cube.AXIS.AXIS_Z;
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
            _freeDrawController.ClearEntireCube();
            this.uxPlaneSelect.Value = 1;
            RefreshVoxelGrid();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            _demoTimer.Start();
            _demoThread.Start();
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
            _demoTimer.Stop();
            _demoThread.Abort();
        }

        private void frmFreeDraw_MouseDown(object sender, MouseEventArgs e)
        {
            // Only care about MouseDown if the sender is a Voxel. We don't need to acknowledge
            // any other MouseDown events, as the MouseClick events of each child control should suffice.
            if ( (sender is Voxel) && 
                (_freeDrawController.CurrentDrawingMode == FreeDraw.DRAWING_MODE.LINE))
            {
                Cursor = Cursors.Cross;
                _isDragging = true;
                _drawVoxelStart = sender as Voxel;
                _drawStart = new Point(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void frmFreeDraw_MouseUp(object sender, MouseEventArgs e)
        {
            // Sender is transmitted as the original sending voxel. 
            if (_isDragging)
            {
                _isDragging = false;
                _drawEnd = new Point(Cursor.Position.X, Cursor.Position.Y);
                _drawEnd = PointToClient(_drawEnd);
                var contained = _voxels.Cast<Voxel>().Where(v => v.Bounds.Contains(_drawEnd));

                if (contained.Count() > 0)
                {
                    _drawVoxelEnd = contained.ToArray<Voxel>()[0];
                }
            }
        }
    }
}
