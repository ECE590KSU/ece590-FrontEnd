namespace CubeMasterGUI
{
    partial class frmMainMenu
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
            this.btnCloseWindow1 = new CubeMasterGUI.btnCloseWindow();
            this.btnAppFreeDraw = new CubeMasterGUI.btnAppLauncher();
            this.SuspendLayout();
            // 
            // btnCloseWindow1
            // 
            this.btnCloseWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCloseWindow1.Location = new System.Drawing.Point(1308, 12);
            this.btnCloseWindow1.Name = "btnCloseWindow1";
            this.btnCloseWindow1.Size = new System.Drawing.Size(30, 30);
            this.btnCloseWindow1.TabIndex = 0;
            // 
            // btnAppFreeDraw
            // 
            this.btnAppFreeDraw.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAppFreeDraw.Location = new System.Drawing.Point(185, 208);
            this.btnAppFreeDraw.Name = "btnAppFreeDraw";
            this.btnAppFreeDraw.Size = new System.Drawing.Size(150, 150);
            this.btnAppFreeDraw.TabIndex = 1;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnAppFreeDraw);
            this.Controls.Add(this.btnCloseWindow1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private btnCloseWindow btnCloseWindow1;
        private btnAppLauncher btnAppFreeDraw;

    }
}