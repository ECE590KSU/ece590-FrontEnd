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
            this.lblWindowName = new System.Windows.Forms.Label();
            this.pnlDrawingControls = new System.Windows.Forms.Panel();
            this.btnDemoStop = new System.Windows.Forms.Button();
            this.btnDemo = new System.Windows.Forms.Button();
            this.btnFillPlane = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearPlane = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxPlaneSelect = new System.Windows.Forms.NumericUpDown();
            this.btnAXIS_Z = new System.Windows.Forms.RadioButton();
            this.btnAXIS_Y = new System.Windows.Forms.RadioButton();
            this.btnAXIS_X = new System.Windows.Forms.RadioButton();
            this.btnCloseWindow1 = new CubeMasterGUI.btnCloseWindow();
            this.tmrFreeDraw = new CubeMasterGUI.ctrlTimer();
            this.pnlDrawingControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxPlaneSelect)).BeginInit();
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
            this.pnlDrawingControls.Controls.Add(this.btnDemoStop);
            this.pnlDrawingControls.Controls.Add(this.btnDemo);
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
            // btnDemoStop
            // 
            this.btnDemoStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemoStop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemoStop.Location = new System.Drawing.Point(517, 435);
            this.btnDemoStop.Name = "btnDemoStop";
            this.btnDemoStop.Size = new System.Drawing.Size(151, 75);
            this.btnDemoStop.TabIndex = 4;
            this.btnDemoStop.Text = "Stop";
            this.btnDemoStop.UseVisualStyleBackColor = true;
            this.btnDemoStop.Click += new System.EventHandler(this.btnDemoStop_Click);
            // 
            // btnDemo
            // 
            this.btnDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemo.Location = new System.Drawing.Point(348, 435);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(151, 75);
            this.btnDemo.TabIndex = 4;
            this.btnDemo.Text = "Demo";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // btnFillPlane
            // 
            this.btnFillPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillPlane.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillPlane.Location = new System.Drawing.Point(183, 236);
            this.btnFillPlane.Name = "btnFillPlane";
            this.btnFillPlane.Size = new System.Drawing.Size(151, 75);
            this.btnFillPlane.TabIndex = 4;
            this.btnFillPlane.Text = "Fill Plane";
            this.btnFillPlane.UseVisualStyleBackColor = true;
            this.btnFillPlane.Click += new System.EventHandler(this.btnFillPlane_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(17, 326);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(151, 75);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClearPlane
            // 
            this.btnClearPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPlane.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPlane.Location = new System.Drawing.Point(17, 236);
            this.btnClearPlane.Name = "btnClearPlane";
            this.btnClearPlane.Size = new System.Drawing.Size(151, 75);
            this.btnClearPlane.TabIndex = 4;
            this.btnClearPlane.Text = "Clear Plane";
            this.btnClearPlane.UseVisualStyleBackColor = true;
            this.btnClearPlane.Click += new System.EventHandler(this.btnClearPlane_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plane Number";
            // 
            // uxPlaneSelect
            // 
            this.uxPlaneSelect.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPlaneSelect.Location = new System.Drawing.Point(17, 186);
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
            this.uxPlaneSelect.Size = new System.Drawing.Size(317, 35);
            this.uxPlaneSelect.TabIndex = 1;
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
            this.btnAXIS_Z.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAXIS_Z.Location = new System.Drawing.Point(17, 89);
            this.btnAXIS_Z.Margin = new System.Windows.Forms.Padding(2);
            this.btnAXIS_Z.Name = "btnAXIS_Z";
            this.btnAXIS_Z.Size = new System.Drawing.Size(239, 36);
            this.btnAXIS_Z.TabIndex = 0;
            this.btnAXIS_Z.TabStop = true;
            this.btnAXIS_Z.Text = "Z Axis (X-Y Plane)";
            this.btnAXIS_Z.UseVisualStyleBackColor = true;
            this.btnAXIS_Z.CheckedChanged += new System.EventHandler(this.btnAXIS_Z_CheckedChanged);
            // 
            // btnAXIS_Y
            // 
            this.btnAXIS_Y.AutoSize = true;
            this.btnAXIS_Y.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAXIS_Y.Location = new System.Drawing.Point(17, 53);
            this.btnAXIS_Y.Margin = new System.Windows.Forms.Padding(2);
            this.btnAXIS_Y.Name = "btnAXIS_Y";
            this.btnAXIS_Y.Size = new System.Drawing.Size(239, 36);
            this.btnAXIS_Y.TabIndex = 0;
            this.btnAXIS_Y.TabStop = true;
            this.btnAXIS_Y.Text = "Y Axis (X-Z Plane)";
            this.btnAXIS_Y.UseVisualStyleBackColor = true;
            this.btnAXIS_Y.CheckedChanged += new System.EventHandler(this.btnAXIS_Y_CheckedChanged);
            // 
            // btnAXIS_X
            // 
            this.btnAXIS_X.AutoSize = true;
            this.btnAXIS_X.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAXIS_X.Location = new System.Drawing.Point(17, 18);
            this.btnAXIS_X.Margin = new System.Windows.Forms.Padding(2);
            this.btnAXIS_X.Name = "btnAXIS_X";
            this.btnAXIS_X.Size = new System.Drawing.Size(239, 36);
            this.btnAXIS_X.TabIndex = 0;
            this.btnAXIS_X.TabStop = true;
            this.btnAXIS_X.Text = "X Axis (Y-Z Plane)";
            this.btnAXIS_X.UseVisualStyleBackColor = true;
            this.btnAXIS_X.CheckedChanged += new System.EventHandler(this.btnAXIS_X_CheckedChanged);
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
    }
}