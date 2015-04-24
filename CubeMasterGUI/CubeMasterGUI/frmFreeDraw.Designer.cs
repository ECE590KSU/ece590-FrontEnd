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
            this.btnAXIS_Z = new System.Windows.Forms.RadioButton();
            this.btnAXIS_Y = new System.Windows.Forms.RadioButton();
            this.btnAXIS_X = new System.Windows.Forms.RadioButton();
            this.btnCloseWindow1 = new CubeMasterGUI.btnCloseWindow();
            this.tmrFreeDraw = new CubeMasterGUI.ctrlTimer();
            this.pnlDrawingControls.SuspendLayout();
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
            this.pnlDrawingControls.Controls.Add(this.btnAXIS_Z);
            this.pnlDrawingControls.Controls.Add(this.btnAXIS_Y);
            this.pnlDrawingControls.Controls.Add(this.btnAXIS_X);
            this.pnlDrawingControls.ForeColor = System.Drawing.Color.SteelBlue;
            this.pnlDrawingControls.Location = new System.Drawing.Point(668, 55);
            this.pnlDrawingControls.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDrawingControls.Name = "pnlDrawingControls";
            this.pnlDrawingControls.Size = new System.Drawing.Size(685, 648);
            this.pnlDrawingControls.TabIndex = 4;
            // 
            // btnAXIS_Z
            // 
            this.btnAXIS_Z.AutoSize = true;
            this.btnAXIS_Z.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAXIS_Z.Location = new System.Drawing.Point(9, 81);
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
            this.btnAXIS_Y.Location = new System.Drawing.Point(9, 45);
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
            this.btnAXIS_X.Location = new System.Drawing.Point(9, 10);
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
    }
}