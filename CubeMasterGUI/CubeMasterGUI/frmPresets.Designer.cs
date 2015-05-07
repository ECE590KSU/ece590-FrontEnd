namespace CubeMasterGUI
{
    partial class frmPresets
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
            this.pnlPresetLauncher = new System.Windows.Forms.Panel();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btnClose = new CubeMasterGUI.btnCloseWindow();
            this.pnlPresetLauncher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPresetLauncher
            // 
            this.pnlPresetLauncher.AutoScroll = true;
            this.pnlPresetLauncher.Controls.Add(this.vScrollBar1);
            this.pnlPresetLauncher.Location = new System.Drawing.Point(250, 30);
            this.pnlPresetLauncher.Name = "pnlPresetLauncher";
            this.pnlPresetLauncher.Size = new System.Drawing.Size(836, 635);
            this.pnlPresetLauncher.TabIndex = 0;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(546, 688);
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(400, 45);
            this.trackBarSpeed.TabIndex = 2;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSpeed.Location = new System.Drawing.Point(393, 688);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(134, 30);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "Effect Speed:";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(932, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 636);
            this.vScrollBar1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClose.Location = new System.Drawing.Point(1324, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            // 
            // frmPresets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlPresetLauncher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPresets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPresets";
            this.Load += new System.EventHandler(this.frmPresets_Load);
            this.pnlPresetLauncher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPresetLauncher;
        private btnCloseWindow btnClose;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}