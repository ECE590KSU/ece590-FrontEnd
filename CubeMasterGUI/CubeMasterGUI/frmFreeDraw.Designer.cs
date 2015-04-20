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
            this.btnAXIS_X = new System.Windows.Forms.RadioButton();
            this.btnAXIS_Y = new System.Windows.Forms.RadioButton();
            this.btnAXIS_Z = new System.Windows.Forms.RadioButton();
            this.btnCloseWindow2 = new CubeMasterGUI.btnCloseWindow();
            this.btnCloseWindow1 = new CubeMasterGUI.btnCloseWindow();
            this.tmrFreeDraw = new CubeMasterGUI.ctrlTimer();
            this.pnlDrawingControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWindowName
            // 
            this.lblWindowName.AutoSize = true;
            this.lblWindowName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindowName.Location = new System.Drawing.Point(20, 20);
            this.lblWindowName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.pnlDrawingControls.Location = new System.Drawing.Point(980, 85);
            this.pnlDrawingControls.Name = "pnlDrawingControls";
            this.pnlDrawingControls.Size = new System.Drawing.Size(918, 968);
            this.pnlDrawingControls.TabIndex = 4;
            // 
            // btnAXIS_X
            // 
            this.btnAXIS_X.AutoSize = true;
            this.btnAXIS_X.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAXIS_X.Location = new System.Drawing.Point(13, 16);
            this.btnAXIS_X.Name = "btnAXIS_X";
            this.btnAXIS_X.Size = new System.Drawing.Size(239, 36);
            this.btnAXIS_X.TabIndex = 0;
            this.btnAXIS_X.TabStop = true;
            this.btnAXIS_X.Text = "X Axis (Y-Z Plane)";
            this.btnAXIS_X.UseVisualStyleBackColor = true;
            // 
            // btnAXIS_Y
            // 
            this.btnAXIS_Y.AutoSize = true;
            this.btnAXIS_Y.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAXIS_Y.Location = new System.Drawing.Point(13, 69);
            this.btnAXIS_Y.Name = "btnAXIS_Y";
            this.btnAXIS_Y.Size = new System.Drawing.Size(239, 36);
            this.btnAXIS_Y.TabIndex = 0;
            this.btnAXIS_Y.TabStop = true;
            this.btnAXIS_Y.Text = "Y Axis (X-Z Plane)";
            this.btnAXIS_Y.UseVisualStyleBackColor = true;
            // 
            // btnAXIS_Z
            // 
            this.btnAXIS_Z.AutoSize = true;
            this.btnAXIS_Z.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAXIS_Z.Location = new System.Drawing.Point(13, 124);
            this.btnAXIS_Z.Name = "btnAXIS_Z";
            this.btnAXIS_Z.Size = new System.Drawing.Size(239, 36);
            this.btnAXIS_Z.TabIndex = 0;
            this.btnAXIS_Z.TabStop = true;
            this.btnAXIS_Z.Text = "Z Axis (X-Y Plane)";
            this.btnAXIS_Z.UseVisualStyleBackColor = true;
            // 
            // btnCloseWindow2
            // 
            this.btnCloseWindow2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCloseWindow2.Location = new System.Drawing.Point(1853, 20);
            this.btnCloseWindow2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCloseWindow2.Name = "btnCloseWindow2";
            this.btnCloseWindow2.Size = new System.Drawing.Size(45, 46);
            this.btnCloseWindow2.TabIndex = 2;
            // 
            // btnCloseWindow1
            // 
            this.btnCloseWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCloseWindow1.Location = new System.Drawing.Point(1962, 20);
            this.btnCloseWindow1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCloseWindow1.Name = "btnCloseWindow1";
            this.btnCloseWindow1.Size = new System.Drawing.Size(45, 46);
            this.btnCloseWindow1.TabIndex = 0;
            // 
            // tmrFreeDraw
            // 
            this.tmrFreeDraw.BackColor = System.Drawing.Color.Transparent;
            this.tmrFreeDraw.Location = new System.Drawing.Point(0, 1061);
            this.tmrFreeDraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tmrFreeDraw.Name = "tmrFreeDraw";
            this.tmrFreeDraw.Size = new System.Drawing.Size(20, 20);
            this.tmrFreeDraw.TabIndex = 3;
            // 
            // frmFreeDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnCloseWindow2);
            this.Controls.Add(this.lblWindowName);
            this.Controls.Add(this.btnCloseWindow1);
            this.Controls.Add(this.pnlDrawingControls);
            this.Controls.Add(this.tmrFreeDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private btnCloseWindow btnCloseWindow2;
        private ctrlTimer tmrFreeDraw;
        private System.Windows.Forms.Panel pnlDrawingControls;
        private System.Windows.Forms.RadioButton btnAXIS_Z;
        private System.Windows.Forms.RadioButton btnAXIS_Y;
        private System.Windows.Forms.RadioButton btnAXIS_X;
    }
}