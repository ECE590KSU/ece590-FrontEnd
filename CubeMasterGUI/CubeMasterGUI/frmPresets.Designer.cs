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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btnClose = new CubeMasterGUI.btnCloseWindow();
            this.pnlPresetLauncher.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPresetLauncher
            // 
            this.pnlPresetLauncher.Controls.Add(this.vScrollBar1);
            this.pnlPresetLauncher.Location = new System.Drawing.Point(13, 13);
            this.pnlPresetLauncher.Name = "pnlPresetLauncher";
            this.pnlPresetLauncher.Size = new System.Drawing.Size(949, 636);
            this.pnlPresetLauncher.TabIndex = 0;
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
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlPresetLauncher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPresets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPresets";
            this.pnlPresetLauncher.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPresetLauncher;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private btnCloseWindow btnClose;
    }
}