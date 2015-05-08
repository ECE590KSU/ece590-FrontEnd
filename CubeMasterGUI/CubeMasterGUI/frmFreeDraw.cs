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
        /// <summary>
        /// The controller class for the Free Draw Form.
        /// </summary>
        private FreeDraw _freeDrawController;

        /// <summary>
        /// A data structure to store the various drawing functions (Single, Line, etc.).
        /// </summary>
        private List<Button> _functions;

        /// <summary>
        /// Allows drawing events requiring multiple clicks to distiniguish between start and
        /// end clicks.
        /// </summary>
        private bool _isSecondClick = false;

        /// <summary>
        /// A 2D drawing point indicating the beginning of a two-click draw event. Useful for 
        /// determining the cursor's location on screen. 
        /// </summary>
        private System.Drawing.Point _drawStart;

        /// <summary>
        /// A 2D drawing point indicating the end of a two-click draw event. Useful for
        /// determining the cursor's location on screen. 
        /// </summary>
        private System.Drawing.Point _drawEnd;

        /// <summary>
        /// The CubeController::Point to begin the drawing function from, using the CubeController.DLL
        /// </summary>
        private CubeController.Point _drawPointStart;

        /// <summary>
        /// The CubeController::Point to end the drawing function on, using the CubeController.DLL
        /// </summary>
        private CubeController.Point _drawPointEnd;
        
        /// <summary>
        /// How many pixels from the left edge of the Free Draw Form to begin drawing the voxel grid.
        /// </summary>
        private int _voxelGrid_startX = 20;

        /// <summary>
        /// How many pixels from the top edge of the Free Draw Form to begin drawing the voxel grid. 
        /// </summary>
        private int _voxelGrid_startY = 75;

        /// <summary>
        /// How many pixels apart each Voxel element should be spaced. 
        /// </summary>
        private int _voxelSpacing = 9;

        /// <summary>
        /// The height of a Voxel control. 
        /// </summary>
        private int _voxelHeight = 80;

        /// <summary>
        /// The width of a Voxel control. 
        /// </summary>
        private int _voxelWidth = 80;

        /// <summary>
        /// The image to display in the preview pane when the user is oriented along the Z axis.
        /// </summary>
        private Bitmap _imgOrientZ;

        /// <summary>
        /// The image to display in the preview pane when the user is oriented along the Y axis.
        /// </summary>
        private Bitmap _imgOrientY;

        /// <summary>
        /// The image to display in the preview pane when the user is oriented along the X axis.
        /// </summary>
        private Bitmap _imgOrientX;

        /// <summary>
        /// A 2D array of Voxel elements, which comprise the drawing grid. 
        /// </summary>
        private Voxel[,] _voxels;

        /// <summary>
        /// The color a clicked Voxel should be painted when displayed to the user.
        /// </summary>
        private Color _clrVoxelClicked = AssetHandler.BtnBackColor_Tertiary;

        /// <summary>
        /// The color an unclicked Voxel should be painted when displayed to the user. 
        /// </summary>
        private Color _clrVoxelUnclicked = AssetHandler.FormBackColor;

        /// <summary>
        /// A timer to control the Demo event (refresh rate, timer tick fidelity, etc.). 
        /// </summary>
        private System.Windows.Forms.Timer _demoTimer;

        /// <summary>
        /// A private thread to compute the Demo event on, in order to constantly refresh this form. 
        /// </summary>
        private System.Threading.Thread _demoThread;

        /// <summary>
        /// Non-default public constructor. Makes no call to the base() constructor, as
        /// arugments are required in order for this object to be instantiated correctly. 
        /// </summary>
        /// <param name="cube">A cube controller object (implements CubeController.DLL), created from the parent controller.</param>
        /// <param name="parentWidth">The width of the parent form in pixels.</param>
        /// <param name="parentHeight">The height of the parent form in pixels.</param>
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

        /// <summary>
        /// Associates the various buttons with their corresponding Bitmap icons. Handles
        /// the creation of these button icons, as well as initializing the default drawing
        /// function's background.  
        /// </summary>
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

            _imgOrientX = new Bitmap(AssetHandler.OrientXURL);
            _imgOrientY = new Bitmap(AssetHandler.OrientYURL);
            _imgOrientZ = new Bitmap(AssetHandler.OrientZURL);

            ToggleSelectedDrawingFunction(this.btnSingle);
        }

        /// <summary>
        /// Creates a new list for the data structure containing the drawing functions. 
        /// Adds the form's controls to this list for easier manipulation. 
        /// </summary>
        private void AssignDrawingFunctions()
        {
            _functions = new List<Button>();
            _functions.Add(this.btnSingle);
            _functions.Add(this.btnLine);
            _functions.Add(this.btnRectangle);
            _functions.Add(this.btnCircle);
        }

        /// <summary>
        /// Initializes the timer embodied by tmrFreeDraw. Takes into account that
        /// the timer may initialize prematurely while in DesignMode. 
        /// </summary>
        private void InvokeTimerProtocol()
        {
            if (!this.DesignMode)
            {
                this.tmrFreeDraw.InitializeTimers();
            }
        }

        /// <summary>
        /// Checks the default radio button to indicate the default axis. 
        /// </summary>
        private void InitializeRadioButtons()
        {
            this.btnAXIS_Y.Checked = true;
        }

        /// <summary>
        /// Renders the Voxel grid to the form. Assigns each Voxel element a 
        /// coordinate, brings each to the front of the form, modifies the cursor to
        /// display when the MouseOver event is raised. Subscribes each Voxel element
        /// frmFreeDraw_VoxelGridClick, which is the primary logic for handling drawing events. 
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

        /// <summary>
        /// Refreshes the Voxel grid on screen to reflect the current state of the CubeController. 
        /// </summary>
        public void RefreshVoxelGrid()
        {
            this.SuspendLayout();
            var tmpplane = _freeDrawController.GetPlane();

            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    _voxels[i, j].BackColor = tmpplane[i][j] ? _clrVoxelClicked : _clrVoxelUnclicked;
                }
            }
            this.ResumeLayout();
        }

        /// <summary>
        /// Creates a new timer (with initialization), and establishes a worker thread, whose
        /// callback is DemoThreadEntry. 
        /// </summary>
        private void SetupDemo()
        {
            _demoTimer = new Timer();
            _demoTimer.Tick += Demo_TimerTick;
            _demoTimer.Interval = 100;
            _demoThread = new System.Threading.Thread(DemoThreadEntry);
        }

        /// <summary>
        /// Anytime the mouse is moved on this form, reset the timers. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFreeDraw_MouseMove(object sender, MouseEventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
        }

        /// <summary>
        /// Anytime the mouse is clicked on this form, reset the timers. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFreeDraw_MouseClick(object sender, MouseEventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
        }

        /// <summary>
        /// Determines the current drawing mode, and the context of the mouse-clicks on 
        /// a Voxel element. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// When switching to the X Axis, make sure to update the controller's
        /// selected axis. Also, update the preview pane for the current orientation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// When switching to the Y Axis, make sure to update the controller's
        /// selected axis. Also, update the preview pane for the current orientation. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// When switching to the Z Axis, make sure to update the controller's
        /// selected axis. Also, update the preview pane for the current orientation. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Clears the current plane of the current axis.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearPlane_Click(object sender, EventArgs e)
        {
            _freeDrawController.ClearPlane();
            RefreshVoxelGrid();
        }

        /// <summary>
        /// Fills the current plane of the current axis. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFillPlane_Click(object sender, EventArgs e)
        {
            _freeDrawController.SetPlane();
            RefreshVoxelGrid();
        }

        /// <summary>
        /// Switches the currently selected plane. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPlaneSelect_ValueChanged(object sender, EventArgs e)
        {
            _freeDrawController.SelectedPlane = (int)(this.uxPlaneSelect.Value - 1);
            RefreshVoxelGrid();
        }

        /// <summary>
        /// Clear every plane of the cube. Reset the selected plane to plane 1. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            _freeDrawController.ClearEntireCube();
            this.uxPlaneSelect.Value = 1;
            RefreshVoxelGrid();
        }

        /// <summary>
        /// Begin a demo for the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Callback for the demo thread.
        /// </summary>
        private void DemoThreadEntry()
        {
            _freeDrawController.Demo();
        }

        /// <summary>
        /// On each timer tick of the demo thread's timer, update the
        /// grid. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Demo_TimerTick(object sender, EventArgs e)
        {
            RefreshVoxelGrid();
        }

        /// <summary>
        /// Reset the timers and end the demo thread. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemoStop_Click(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            _demoTimer.Stop();
            _demoThread.Abort();
            _freeDrawController.ClearEntireCube();
            RefreshVoxelGrid();
        }

        /// <summary>
        /// Set the current drawing mode to SINGLE.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSingle_Click(object sender, EventArgs e)
        {
            _freeDrawController.CurrentDrawingMode = FreeDraw.DRAWING_MODE.SINGLE;
            _isSecondClick = false;
            ToggleSelectedDrawingFunction(sender as Button);
        }

        /// <summary>
        /// Set the current drawing mode to LINE.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLine_Click(object sender, EventArgs e)
        {
            _freeDrawController.CurrentDrawingMode = FreeDraw.DRAWING_MODE.LINE;
            _isSecondClick = false;
            ToggleSelectedDrawingFunction(sender as Button);
        }

        /// <summary>
        /// Set the current drawing mode to RECTANGLE.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            _freeDrawController.CurrentDrawingMode = FreeDraw.DRAWING_MODE.RECTANGLE;
            _isSecondClick = false;
            ToggleSelectedDrawingFunction(sender as Button);
        }

        /// <summary>
        /// Set the current drawing mode to CIRCLE. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCircle_Click(object sender, EventArgs e)
        {
            _freeDrawController.CurrentDrawingMode = FreeDraw.DRAWING_MODE.CIRCLE;
            _isSecondClick = false;
            ToggleSelectedDrawingFunction(sender as Button);
        }

        /// <summary>
        /// Distinguishes the current drawing mode button by changing its
        /// background color and setting an alternate button icon. 
        /// </summary>
        /// <param name="sender"></param>
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

        /// <summary>
        /// Copy the current plane on the current axis. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            _freeDrawController.CopyPlane();
            RefreshVoxelGrid();
        }

        /// <summary>
        /// Paste the copied plane into the current plane on the current axis.
        /// User can attempt to paste before copying, as this is handled by
        /// the Free Draw controller. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPaste_Click(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            _freeDrawController.PastePlane();
            RefreshVoxelGrid();
        }

        /// <summary>
        /// Rotate the current plane clockwise. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRotateCW_Click(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            _freeDrawController.Rotate(270);
            RefreshVoxelGrid();
        }

        /// <summary>
        /// Rotate the current plane counter-clockwise.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Sets the reflection parameter. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbReflection_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            string optionSelected = this.cmbReflection.SelectedItem.ToString();
            _freeDrawController.SetReflection(optionSelected);
        }

        /// <summary>
        /// Shifts all the planes "UP" by one. Shifts with roll,
        /// as this is the outcome a typical user would expect.
        /// 
        /// "UP" is away from the origin towards terminus along the
        /// currently selected axis of orientation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShiftUp_Click(object sender, EventArgs e)
        {
            this.tmrFreeDraw.ResetTimers();
            _freeDrawController.ShiftUp();
            RefreshVoxelGrid();
        }

        /// <summary>
        /// Shifts all the planes "DOWN" by one. Shifts with roll,
        /// as this is the outcome a typical user would expect.
        /// 
        /// "DOWN" is towards origin from terminus along the currently
        /// selected axis of orientation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Allows the user to change the selected plane via the mousewheel. Makes for a
        /// much smoother interaction with the UI. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="me"></param>
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

        /// <summary>
        /// Attempting to intercept arrow key events, and prevent them from
        /// raising btnAXIS_*_CheckChanged events. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
