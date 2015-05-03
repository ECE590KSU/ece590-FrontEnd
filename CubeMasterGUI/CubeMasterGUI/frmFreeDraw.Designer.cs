namespace CubeMasterGUI
{
    partial class frmFreeDraw
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblWindowName = new System.Windows.Forms.Label();
            this.pnlDrawingControls = new System.Windows.Forms.Panel();
            this.btnRotateCW = new System.Windows.Forms.Button();
            this.btnRotateCCW = new System.Windows.Forms.Button();
            this.btnDemoStop = new System.Windows.Forms.Button();
            this.btnSingle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnMirrorX = new System.Windows.Forms.Button();
            this.btnDemo = new System.Windows.Forms.Button();
            this.btnFillPlane = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearPlane = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxPlaneSelect = new System.Windows.Forms.NumericUpDown();
            this.btnAXIS_Z = new System.Windows.Forms.RadioButton();
            this.btnAXIS_Y = new System.Windows.Forms.RadioButton();
            this.btnAXIS_X = new System.Windows.Forms.RadioButton();
            this.ttFreeDraw = new System.Windows.Forms.ToolTip(this.components);
            this.btnMirrorY = new System.Windows.Forms.Button();
            this.btnMirrorZ = new System.Windows.Forms.Button();
            this.cmbReflection = new System.Windows.Forms.ComboBox();
            this.btnShiftUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnCloseWindow1 = new CubeMasterGUI.btnCloseWindow();
            this.tmrFreeDraw = new CubeMasterGUI.ctrlTimer();
            this.pnlDrawingControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxPlaneSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWindowName
            // 
            this.lblWindowName.AutoSize = true;
            this.lblWindowName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindowName.Location = new System.Drawing.Point(13, 13);
            this.lblWindowName.Name = "lblWindowName";
            this.lblWindowName.Size = new System.Drawing.Size(0, 25);
            this.lblWindowName.TabIndex = 1;
            // 
            // pnlDrawingControls
            // 
            this.pnlDrawingControls.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDrawingControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawingControls.Controls.Add(this.picPreview);
            this.pnlDrawingControls.Controls.Add(this.cmbReflection);
            this.pnlDrawingControls.Controls.Add(this.btnRotateCW);
            this.pnlDrawingControls.Controls.Add(this.btnRotateCCW);
            this.pnlDrawingControls.Controls.Add(this.btnDemoStop);
            this.pnlDrawingControls.Controls.Add(this.btnSingle);
            this.pnlDrawingControls.Controls.Add(this.btnRectangle);
            this.pnlDrawingControls.Controls.Add(this.btnCircle);
            this.pnlDrawingControls.Controls.Add(this.btnLine);
            this.pnlDrawingControls.Controls.Add(this.btnCopy);
            this.pnlDrawingControls.Controls.Add(this.btnPaste);
            this.pnlDrawingControls.Controls.Add(this.btnMirrorZ);
            this.pnlDrawingControls.Controls.Add(this.btnMirrorY);
            this.pnlDrawingControls.Controls.Add(this.btnMirrorX);
            this.pnlDrawingControls.Controls.Add(this.btnDemo);
            this.pnlDrawingControls.Controls.Add(this.button1);
            this.pnlDrawingControls.Controls.Add(this.btnShiftUp);
            this.pnlDrawingControls.Controls.Add(this.btnFillPlane);
            this.pnlDrawingControls.Controls.Add(this.btnClearAll);
            this.pnlDrawingControls.Controls.Add(this.btnClearPlane);
            this.pnlDrawingControls.Controls.Add(this.label1);
            this.pnlDrawingControls.Controls.Add(this.uxPlaneSelect);
            this.pnlDrawingControls.Controls.Add(this.btnAXIS_Z);
            this.pnlDrawingControls.Controls.Add(this.btnAXIS_Y);
            this.pnlDrawingControls.Controls.Add(this.btnAXIS_X);
            this.pnlDrawingControls.ForeColor = System.Drawing.Color.SteelBlue;
            this.pnlDrawingControls.Location = new System.Drawing.Point(668, 55);
            this.pnlDrawingControls.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDrawingControls.Name = "pnlDrawingControls";
            this.pnlDrawingControls.Size = new System.Drawing.Size(685, 702);
            this.pnlDrawingControls.TabIndex = 4;
            // 
            // btnRotateCW
            // 
            this.btnRotateCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotateCW.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateCW.Location = new System.Drawing.Point(263, 351);
            this.btnRotateCW.Name = "btnRotateCW";
            this.btnRotateCW.Size = new System.Drawing.Size(70, 75);
            this.btnRotateCW.TabIndex = 5;
            this.ttFreeDraw.SetToolTip(this.btnRotateCW, "Rotate clock-wise.");
            this.btnRotateCW.UseVisualStyleBackColor = true;
            this.btnRotateCW.Click += new System.EventHandler(this.btnRotateCW_Click);
            // 
            // btnRotateCCW
            // 
            this.btnRotateCCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotateCCW.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateCCW.Location = new System.Drawing.Point(183, 351);
            this.btnRotateCCW.Name = "btnRotateCCW";
            this.btnRotateCCW.Size = new System.Drawing.Size(70, 75);
            this.btnRotateCCW.TabIndex = 5;
            this.ttFreeDraw.SetToolTip(this.btnRotateCCW, "Rotate counter-clock-wise.");
            this.btnRotateCCW.UseVisualStyleBackColor = true;
            this.btnRotateCCW.Click += new System.EventHandler(this.btnRotateCCW_Click);
            // 
            // btnDemoStop
            // 
            this.btnDemoStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemoStop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemoStop.Location = new System.Drawing.Point(517, 442);
            this.btnDemoStop.Name = "btnDemoStop";
            this.btnDemoStop.Size = new System.Drawing.Size(150, 75);
            this.btnDemoStop.TabIndex = 4;
            this.ttFreeDraw.SetToolTip(this.btnDemoStop, "Stops the demo.");
            this.btnDemoStop.UseVisualStyleBackColor = true;
            this.btnDemoStop.Click += new System.EventHandler(this.btnDemoStop_Click);
            // 
            // btnSingle
            // 
            this.btnSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingle.Location = new System.Drawing.Point(17, 533);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(150, 150);
            this.btnSingle.TabIndex = 4;
            this.btnSingle.Text = "Single";
            this.ttFreeDraw.SetToolTip(this.btnSingle, "Click on a Voxel (the\r\nbig grid) to alter its\r\nstate (ON or OFF).");
            this.btnSingle.UseVisualStyleBackColor = true;
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRectangle.Location = new System.Drawing.Point(348, 533);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(150, 150);
            this.btnRectangle.TabIndex = 4;
            this.btnRectangle.Text = "Rectangle";
            this.ttFreeDraw.SetToolTip(this.btnRectangle, "Click on two Voxels and\r\na rectangle will be drawn\r\nbetween them. Best if used\r\no" +
        "n the same plane.");
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircle.Location = new System.Drawing.Point(517, 533);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(150, 150);
            this.btnCircle.TabIndex = 4;
            this.btnCircle.Text = "Circle";
            this.ttFreeDraw.SetToolTip(this.btnCircle, "Click on a Voxel where the\r\ncenter of the circle should be,\r\nand then click on a " +
        "voxel for\r\nits outer line. Watch magic happen!");
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnLine
            // 
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLine.Location = new System.Drawing.Point(183, 533);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(150, 150);
            this.btnLine.TabIndex = 4;
            this.btnLine.Text = "Line";
            this.ttFreeDraw.SetToolTip(this.btnLine, "Click on two Voxels to\r\ndraw a line between them. \r\nThey do not have to be on the" +
        "\r\nsame plane, or even axis!");
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(17, 442);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(150, 75);
            this.btnCopy.TabIndex = 4;
            this.ttFreeDraw.SetToolTip(this.btnCopy, "Like this pattern? \r\nSave it for later! (use Paste)");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaste.Location = new System.Drawing.Point(183, 442);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(150, 75);
            this.btnPaste.TabIndex = 4;
            this.ttFreeDraw.SetToolTip(this.btnPaste, "Pastes your saved pattern.");
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnMirrorX
            // 
            this.btnMirrorX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMirrorX.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMirrorX.Location = new System.Drawing.Point(517, 60);
            this.btnMirrorX.Name = "btnMirrorX";
            this.btnMirrorX.Size = new System.Drawing.Size(150, 36);
            this.btnMirrorX.TabIndex = 4;
            this.btnMirrorX.Text = "Mirror X";
            this.ttFreeDraw.SetToolTip(this.btnMirrorX, "Take what\'s on the X-Axis,\r\nand mirror it (symmetry).\r\n");
            this.btnMirrorX.UseVisualStyleBackColor = true;
            this.btnMirrorX.Click += new System.EventHandler(this.btnMirrorX_Click);
            // 
            // btnDemo
            // 
            this.btnDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemo.Location = new System.Drawing.Point(348, 442);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(150, 75);
            this.btnDemo.TabIndex = 4;
            this.ttFreeDraw.SetToolTip(this.btnDemo, "Simulates a short\r\ndemonstration.");
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // btnFillPlane
            // 
            this.btnFillPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillPlane.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillPlane.Location = new System.Drawing.Point(183, 261);
            this.btnFillPlane.Name = "btnFillPlane";
            this.btnFillPlane.Size = new System.Drawing.Size(151, 75);
            this.btnFillPlane.TabIndex = 4;
            this.btnFillPlane.Text = "Fill Plane";
            this.ttFreeDraw.SetToolTip(this.btnFillPlane, "Turn on every Voxel on this plane.");
            this.btnFillPlane.UseVisualStyleBackColor = true;
            this.btnFillPlane.Click += new System.EventHandler(this.btnFillPlane_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(17, 351);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(151, 75);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Clear All";
            this.ttFreeDraw.SetToolTip(this.btnClearAll, "Start from scratch.");
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClearPlane
            // 
            this.btnClearPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPlane.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPlane.Location = new System.Drawing.Point(17, 261);
            this.btnClearPlane.Name = "btnClearPlane";
            this.btnClearPlane.Size = new System.Drawing.Size(151, 75);
            this.btnClearPlane.TabIndex = 4;
            this.btnClearPlane.Text = "Clear Plane";
            this.ttFreeDraw.SetToolTip(this.btnClearPlane, "Don\'t like this plane? No problem.");
            this.btnClearPlane.UseVisualStyleBackColor = true;
            this.btnClearPlane.Click += new System.EventHandler(this.btnClearPlane_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(11, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plane #";
            // 
            // uxPlaneSelect
            // 
            this.uxPlaneSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxPlaneSelect.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPlaneSelect.Location = new System.Drawing.Point(116, 216);
            this.uxPlaneSelect.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.uxPlaneSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxPlaneSelect.Name = "uxPlaneSelect";
            this.uxPlaneSelect.Size = new System.Drawing.Size(218, 35);
            this.uxPlaneSelect.TabIndex = 1;
            this.ttFreeDraw.SetToolTip(this.uxPlaneSelect, "Pick which plane to draw on!");
            this.uxPlaneSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxPlaneSelect.ValueChanged += new System.EventHandler(this.uxPlaneSelect_ValueChanged);
            // 
            // btnAXIS_Z
            // 
            this.btnAXIS_Z.AutoSize = true;
            this.btnAXIS_Z.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAXIS_Z.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAXIS_Z.Location = new System.Drawing.Point(17, 89);
            this.btnAXIS_Z.Margin = new System.Windows.Forms.Padding(2);
            this.btnAXIS_Z.Name = "btnAXIS_Z";
            this.btnAXIS_Z.Size = new System.Drawing.Size(238, 36);
            this.btnAXIS_Z.TabIndex = 0;
            this.btnAXIS_Z.TabStop = true;
            this.btnAXIS_Z.Text = "Z Axis (X-Y Plane)";
            this.ttFreeDraw.SetToolTip(this.btnAXIS_Z, "Draw along the Z-Axis.");
            this.btnAXIS_Z.UseVisualStyleBackColor = true;
            this.btnAXIS_Z.CheckedChanged += new System.EventHandler(this.btnAXIS_Z_CheckedChanged);
            // 
            // btnAXIS_Y
            // 
            this.btnAXIS_Y.AutoSize = true;
            this.btnAXIS_Y.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAXIS_Y.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAXIS_Y.Location = new System.Drawing.Point(17, 53);
            this.btnAXIS_Y.Margin = new System.Windows.Forms.Padding(2);
            this.btnAXIS_Y.Name = "btnAXIS_Y";
            this.btnAXIS_Y.Size = new System.Drawing.Size(238, 36);
            this.btnAXIS_Y.TabIndex = 0;
            this.btnAXIS_Y.TabStop = true;
            this.btnAXIS_Y.Text = "Y Axis (X-Z Plane)";
            this.ttFreeDraw.SetToolTip(this.btnAXIS_Y, "Draw along the Y-Axis.");
            this.btnAXIS_Y.UseVisualStyleBackColor = true;
            this.btnAXIS_Y.CheckedChanged += new System.EventHandler(this.btnAXIS_Y_CheckedChanged);
            // 
            // btnAXIS_X
            // 
            this.btnAXIS_X.AutoSize = true;
            this.btnAXIS_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAXIS_X.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAXIS_X.Location = new System.Drawing.Point(17, 18);
            this.btnAXIS_X.Margin = new System.Windows.Forms.Padding(2);
            this.btnAXIS_X.Name = "btnAXIS_X";
            this.btnAXIS_X.Size = new System.Drawing.Size(238, 36);
            this.btnAXIS_X.TabIndex = 0;
            this.btnAXIS_X.TabStop = true;
            this.btnAXIS_X.Text = "X Axis (Y-Z Plane)";
            this.ttFreeDraw.SetToolTip(this.btnAXIS_X, "Draw along the X-Axis.");
            this.btnAXIS_X.UseVisualStyleBackColor = true;
            this.btnAXIS_X.CheckedChanged += new System.EventHandler(this.btnAXIS_X_CheckedChanged);
            // 
            // ttFreeDraw
            // 
            this.ttFreeDraw.ShowAlways = true;
            // 
            // btnMirrorY
            // 
            this.btnMirrorY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMirrorY.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMirrorY.Location = new System.Drawing.Point(517, 102);
            this.btnMirrorY.Name = "btnMirrorY";
            this.btnMirrorY.Size = new System.Drawing.Size(150, 36);
            this.btnMirrorY.TabIndex = 4;
            this.btnMirrorY.Text = "Mirror Y";
            this.ttFreeDraw.SetToolTip(this.btnMirrorY, "Take what\'s along the\r\nY-Axis, and mirror it (symmetry).");
            this.btnMirrorY.UseVisualStyleBackColor = true;
            this.btnMirrorY.Click += new System.EventHandler(this.btnMirrorY_Click);
            // 
            // btnMirrorZ
            // 
            this.btnMirrorZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMirrorZ.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMirrorZ.Location = new System.Drawing.Point(517, 144);
            this.btnMirrorZ.Name = "btnMirrorZ";
            this.btnMirrorZ.Size = new System.Drawing.Size(150, 36);
            this.btnMirrorZ.TabIndex = 4;
            this.btnMirrorZ.Text = "Mirror Z";
            this.ttFreeDraw.SetToolTip(this.btnMirrorZ, "Take what\'s on the X-Axis,\r\nand mirror it (symmetry).");
            this.btnMirrorZ.UseVisualStyleBackColor = true;
            this.btnMirrorZ.Click += new System.EventHandler(this.btnMirrorZ_Click);
            // 
            // cmbReflection
            // 
            this.cmbReflection.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbReflection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReflection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReflection.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReflection.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbReflection.FormattingEnabled = true;
            this.cmbReflection.Items.AddRange(new object[] {
            "Origin",
            "Terminus"});
            this.cmbReflection.Location = new System.Drawing.Point(517, 16);
            this.cmbReflection.Name = "cmbReflection";
            this.cmbReflection.Size = new System.Drawing.Size(150, 38);
            this.cmbReflection.TabIndex = 6;
            this.cmbReflection.TabStop = false;
            this.ttFreeDraw.SetToolTip(this.cmbReflection, "Do you want to reflect what\'s \r\ncloser to you (ORIGIN), or\r\nwhat\'s further from y" +
        "ou (TERMINUS)?");
            this.cmbReflection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnShiftUp
            // 
            this.btnShiftUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShiftUp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftUp.Location = new System.Drawing.Point(348, 261);
            this.btnShiftUp.Name = "btnShiftUp";
            this.btnShiftUp.Size = new System.Drawing.Size(150, 75);
            this.btnShiftUp.TabIndex = 4;
            this.btnShiftUp.Text = "Shift Forward";
            this.ttFreeDraw.SetToolTip(this.btnShiftUp, "Roll through your planes\r\nin increasing plane order.");
            this.btnShiftUp.UseVisualStyleBackColor = true;
            this.btnShiftUp.Click += new System.EventHandler(this.btnShiftUp_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(348, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "Shift Reverse";
            this.ttFreeDraw.SetToolTip(this.button1, "Roll through your planes\r\nin decreasing plane order.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(348, 30);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(150, 150);
            this.picPreview.TabIndex = 7;
            this.picPreview.TabStop = false;
            this.ttFreeDraw.SetToolTip(this.picPreview, "You\'re oriented along the blue face,\r\nthe red arrow indicating an increasing\r\npla" +
        "ne number.");
            // 
            // btnCloseWindow1
            // 
            this.btnCloseWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCloseWindow1.Location = new System.Drawing.Point(1323, 13);
            this.btnCloseWindow1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCloseWindow1.Name = "btnCloseWindow1";
            this.btnCloseWindow1.Size = new System.Drawing.Size(30, 30);
            this.btnCloseWindow1.TabIndex = 0;
            // 
            // tmrFreeDraw
            // 
            this.tmrFreeDraw.BackColor = System.Drawing.Color.Transparent;
            this.tmrFreeDraw.Location = new System.Drawing.Point(0, 690);
            this.tmrFreeDraw.Name = "tmrFreeDraw";
            this.tmrFreeDraw.Size = new System.Drawing.Size(13, 13);
            this.tmrFreeDraw.TabIndex = 3;
            // 
            // frmFreeDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.lblWindowName);
            this.Controls.Add(this.btnCloseWindow1);
            this.Controls.Add(this.pnlDrawingControls);
            this.Controls.Add(this.tmrFreeDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFreeDraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFreeDraw";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmFreeDraw_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmFreeDraw_MouseMove);
            this.pnlDrawingControls.ResumeLayout(false);
            this.pnlDrawingControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxPlaneSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btnCloseWindow btnCloseWindow1;
        private System.Windows.Forms.Label lblWindowName;
        private ctrlTimer tmrFreeDraw;
        private System.Windows.Forms.Panel pnlDrawingControls;
        private System.Windows.Forms.RadioButton btnAXIS_Z;
        private System.Windows.Forms.RadioButton btnAXIS_Y;
        private System.Windows.Forms.RadioButton btnAXIS_X;
        private System.Windows.Forms.NumericUpDown uxPlaneSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearPlane;
        private System.Windows.Forms.Button btnFillPlane;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Button btnDemoStop;
        private System.Windows.Forms.Button btnSingle;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.ToolTip ttFreeDraw;
        private System.Windows.Forms.Button btnMirrorX;
        private System.Windows.Forms.Button btnRotateCW;
        private System.Windows.Forms.Button btnRotateCCW;
        private System.Windows.Forms.Button btnMirrorZ;
        private System.Windows.Forms.Button btnMirrorY;
        private System.Windows.Forms.ComboBox cmbReflection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShiftUp;
        private System.Windows.Forms.PictureBox picPreview;
    }
}