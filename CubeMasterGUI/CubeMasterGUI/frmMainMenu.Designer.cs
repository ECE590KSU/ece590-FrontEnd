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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.appGame = new CubeMasterGUI.AppLauncher();
            this.appText2Cube = new CubeMasterGUI.AppLauncher();
            this.appAudioVis = new CubeMasterGUI.AppLauncher();
            this.appPreset = new CubeMasterGUI.AppLauncher();
            this.appFreeDraw = new CubeMasterGUI.AppLauncher();
            this.btnCloseWindow1 = new CubeMasterGUI.btnCloseWindow();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(862, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 656);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(862, 656);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "label1";
            // 
            // appGame
            // 
            this.appGame.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.appGame.Location = new System.Drawing.Point(830, 553);
            this.appGame.Name = "appGame";
            this.appGame.Size = new System.Drawing.Size(100, 100);
            this.appGame.TabIndex = 1;
            // 
            // appText2Cube
            // 
            this.appText2Cube.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.appText2Cube.Location = new System.Drawing.Point(830, 174);
            this.appText2Cube.Name = "appText2Cube";
            this.appText2Cube.Size = new System.Drawing.Size(100, 100);
            this.appText2Cube.TabIndex = 1;
            // 
            // appAudioVis
            // 
            this.appAudioVis.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.appAudioVis.Location = new System.Drawing.Point(616, 368);
            this.appAudioVis.Name = "appAudioVis";
            this.appAudioVis.Size = new System.Drawing.Size(100, 100);
            this.appAudioVis.TabIndex = 1;
            // 
            // appPreset
            // 
            this.appPreset.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.appPreset.Location = new System.Drawing.Point(377, 553);
            this.appPreset.Name = "appPreset";
            this.appPreset.Size = new System.Drawing.Size(100, 100);
            this.appPreset.TabIndex = 1;
            // 
            // appFreeDraw
            // 
            this.appFreeDraw.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.appFreeDraw.Location = new System.Drawing.Point(377, 174);
            this.appFreeDraw.Name = "appFreeDraw";
            this.appFreeDraw.Size = new System.Drawing.Size(100, 100);
            this.appFreeDraw.TabIndex = 1;
            // 
            // btnCloseWindow1
            // 
            this.btnCloseWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCloseWindow1.Location = new System.Drawing.Point(1308, 12);
            this.btnCloseWindow1.Name = "btnCloseWindow1";
            this.btnCloseWindow1.Size = new System.Drawing.Size(30, 30);
            this.btnCloseWindow1.TabIndex = 0;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appGame);
            this.Controls.Add(this.appText2Cube);
            this.Controls.Add(this.appAudioVis);
            this.Controls.Add(this.appPreset);
            this.Controls.Add(this.appFreeDraw);
            this.Controls.Add(this.btnCloseWindow1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btnCloseWindow btnCloseWindow1;
        private AppLauncher appFreeDraw;
        private AppLauncher appPreset;
        private AppLauncher appAudioVis;
        private AppLauncher appText2Cube;
        private AppLauncher appGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}