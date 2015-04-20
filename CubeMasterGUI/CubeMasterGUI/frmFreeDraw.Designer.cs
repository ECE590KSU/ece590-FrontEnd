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
            this.tmrFreeDraw = new CubeMasterGUI.ctrlTimer();
            this.btnCloseWindow2 = new CubeMasterGUI.btnCloseWindow();
            this.btnCloseWindow1 = new CubeMasterGUI.btnCloseWindow();
            this.SuspendLayout();
            // 
            // lblWindowName
            // 
            this.lblWindowName.AutoSize = true;
            this.lblWindowName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindowName.Location = new System.Drawing.Point(20, 20);
            this.lblWindowName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWindowName.Name = "lblWindowName";
            this.lblWindowName.Size = new System.Drawing.Size(0, 40);
            this.lblWindowName.TabIndex = 1;
            // 
            // tmrFreeDraw
            // 
            this.tmrFreeDraw.BackColor = System.Drawing.Color.Transparent;
            this.tmrFreeDraw.Location = new System.Drawing.Point(13, 1022);
            this.tmrFreeDraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tmrFreeDraw.Name = "tmrFreeDraw";
            this.tmrFreeDraw.Size = new System.Drawing.Size(45, 46);
            this.tmrFreeDraw.TabIndex = 3;
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
            // frmFreeDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tmrFreeDraw);
            this.Controls.Add(this.btnCloseWindow2);
            this.Controls.Add(this.lblWindowName);
            this.Controls.Add(this.btnCloseWindow1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFreeDraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFreeDraw";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmFreeDraw_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmFreeDraw_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btnCloseWindow btnCloseWindow1;
        private System.Windows.Forms.Label lblWindowName;
        private btnCloseWindow btnCloseWindow2;
        private ctrlTimer tmrFreeDraw;
    }
}