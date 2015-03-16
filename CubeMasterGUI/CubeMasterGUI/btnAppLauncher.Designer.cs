namespace CubeMasterGUI
{
    partial class btnAppLauncher
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBkgd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBkgd)).BeginInit();
            this.SuspendLayout();
            // 
            // picBkgd
            // 
            this.picBkgd.Location = new System.Drawing.Point(4, 4);
            this.picBkgd.Name = "picBkgd";
            this.picBkgd.Size = new System.Drawing.Size(143, 143);
            this.picBkgd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBkgd.TabIndex = 0;
            this.picBkgd.TabStop = false;
            // 
            // btnAppLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.picBkgd);
            this.Name = "btnAppLauncher";
            ((System.ComponentModel.ISupportInitialize)(this.picBkgd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox picBkgd;

    }
}
