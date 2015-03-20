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
            this.components = new System.ComponentModel.Container();
            this.lblFreeDraw = new System.Windows.Forms.Label();
            this.lblText2Cube = new System.Windows.Forms.Label();
            this.lblAudioVis = new System.Windows.Forms.Label();
            this.lblPreset = new System.Windows.Forms.Label();
            this.lblGames = new System.Windows.Forms.Label();
            this.MainMenuTimer = new CubeMasterGUI.ctrlTimer();
            this.appGame = new CubeMasterGUI.AppLauncher();
            this.appText2Cube = new CubeMasterGUI.AppLauncher();
            this.appAudioVis = new CubeMasterGUI.AppLauncher();
            this.appPreset = new CubeMasterGUI.AppLauncher();
            this.appFreeDraw = new CubeMasterGUI.AppLauncher();
            this.btnCloseWindow1 = new CubeMasterGUI.btnCloseWindow();
            this.appLauncherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.appLauncherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFreeDraw
            // 
            this.lblFreeDraw.AutoSize = true;
            this.lblFreeDraw.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreeDraw.Location = new System.Drawing.Point(213, 189);
            this.lblFreeDraw.Name = "lblFreeDraw";
            this.lblFreeDraw.Size = new System.Drawing.Size(94, 20);
            this.lblFreeDraw.TabIndex = 2;
            this.lblFreeDraw.Text = "FREE DRAW";
            // 
            // lblText2Cube
            // 
            this.lblText2Cube.AutoSize = true;
            this.lblText2Cube.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2Cube.Location = new System.Drawing.Point(1006, 189);
            this.lblText2Cube.Name = "lblText2Cube";
            this.lblText2Cube.Size = new System.Drawing.Size(100, 20);
            this.lblText2Cube.TabIndex = 2;
            this.lblText2Cube.Text = "TEXT 2 CUBE";
            // 
            // lblAudioVis
            // 
            this.lblAudioVis.AutoSize = true;
            this.lblAudioVis.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudioVis.Location = new System.Drawing.Point(619, 400);
            this.lblAudioVis.Name = "lblAudioVis";
            this.lblAudioVis.Size = new System.Drawing.Size(147, 20);
            this.lblAudioVis.TabIndex = 2;
            this.lblAudioVis.Text = "AUDIO VISUALIZER";
            // 
            // lblPreset
            // 
            this.lblPreset.AutoSize = true;
            this.lblPreset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreset.Location = new System.Drawing.Point(212, 656);
            this.lblPreset.Name = "lblPreset";
            this.lblPreset.Size = new System.Drawing.Size(69, 20);
            this.lblPreset.TabIndex = 2;
            this.lblPreset.Text = "PRESETS";
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGames.Location = new System.Drawing.Point(1010, 656);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(61, 20);
            this.lblGames.TabIndex = 2;
            this.lblGames.Text = "GAMES";
            // 
            // MainMenuTimer
            // 
            this.MainMenuTimer.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuTimer.Location = new System.Drawing.Point(3, 742);
            this.MainMenuTimer.Name = "MainMenuTimer";
            this.MainMenuTimer.Size = new System.Drawing.Size(30, 30);
            this.MainMenuTimer.TabIndex = 3;
            // 
            // appGame
            // 
            this.appGame.AutoSize = true;
            this.appGame.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.appGame.Location = new System.Drawing.Point(1010, 575);
            this.appGame.Name = "appGame";
            this.appGame.Size = new System.Drawing.Size(200, 100);
            this.appGame.TabIndex = 1;
            // 
            // appText2Cube
            // 
            this.appText2Cube.AutoSize = true;
            this.appText2Cube.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.appText2Cube.Location = new System.Drawing.Point(1010, 108);
            this.appText2Cube.Name = "appText2Cube";
            this.appText2Cube.Size = new System.Drawing.Size(200, 100);
            this.appText2Cube.TabIndex = 1;
            // 
            // appAudioVis
            // 
            this.appAudioVis.AutoSize = true;
            this.appAudioVis.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.appAudioVis.Location = new System.Drawing.Point(619, 320);
            this.appAudioVis.Name = "appAudioVis";
            this.appAudioVis.Size = new System.Drawing.Size(200, 100);
            this.appAudioVis.TabIndex = 1;
            // 
            // appPreset
            // 
            this.appPreset.AutoSize = true;
            this.appPreset.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.appPreset.Location = new System.Drawing.Point(212, 575);
            this.appPreset.Name = "appPreset";
            this.appPreset.Size = new System.Drawing.Size(200, 100);
            this.appPreset.TabIndex = 1;
            // 
            // appFreeDraw
            // 
            this.appFreeDraw.AutoSize = true;
            this.appFreeDraw.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.appFreeDraw.Location = new System.Drawing.Point(213, 109);
            this.appFreeDraw.Name = "appFreeDraw";
            this.appFreeDraw.Size = new System.Drawing.Size(200, 100);
            this.appFreeDraw.TabIndex = 1;
            this.appFreeDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.appFreeDraw_MouseClick);
            // 
            // btnCloseWindow1
            // 
            this.btnCloseWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCloseWindow1.Location = new System.Drawing.Point(1308, 12);
            this.btnCloseWindow1.Name = "btnCloseWindow1";
            this.btnCloseWindow1.Size = new System.Drawing.Size(30, 30);
            this.btnCloseWindow1.TabIndex = 0;
            // 
            // appLauncherBindingSource
            // 
            this.appLauncherBindingSource.DataSource = typeof(CubeMasterGUI.AppLauncher);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.MainMenuTimer);
            this.Controls.Add(this.lblPreset);
            this.Controls.Add(this.lblAudioVis);
            this.Controls.Add(this.lblGames);
            this.Controls.Add(this.lblText2Cube);
            this.Controls.Add(this.lblFreeDraw);
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
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMainMenu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.appLauncherBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lblFreeDraw;
        private System.Windows.Forms.Label lblText2Cube;
        private System.Windows.Forms.Label lblAudioVis;
        private System.Windows.Forms.Label lblPreset;
        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.BindingSource appLauncherBindingSource;
        private ctrlTimer MainMenuTimer;

    }
}