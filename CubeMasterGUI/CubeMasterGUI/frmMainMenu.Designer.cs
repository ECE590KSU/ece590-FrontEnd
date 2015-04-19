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
            this.lblFreeDraw = new System.Windows.Forms.Label();
            this.lblText2Cube = new System.Windows.Forms.Label();
            this.lblAudioVis = new System.Windows.Forms.Label();
            this.lblPreset = new System.Windows.Forms.Label();
            this.lblGames = new System.Windows.Forms.Label();
            this.btnFreeDraw = new System.Windows.Forms.Button();
            this.btnText2Cube = new System.Windows.Forms.Button();
            this.btnAudioVis = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.btnPresets = new System.Windows.Forms.Button();
            this.MainMenuTimer = new CubeMasterGUI.ctrlTimer();
            this.btnCloseWindow1 = new CubeMasterGUI.btnCloseWindow();
            this.SuspendLayout();
            // 
            // lblFreeDraw
            // 
            this.lblFreeDraw.AutoSize = true;
            this.lblFreeDraw.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreeDraw.Location = new System.Drawing.Point(172, 291);
            this.lblFreeDraw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFreeDraw.Name = "lblFreeDraw";
            this.lblFreeDraw.Size = new System.Drawing.Size(141, 31);
            this.lblFreeDraw.TabIndex = 2;
            this.lblFreeDraw.Text = "FREE DRAW";
            // 
            // lblText2Cube
            // 
            this.lblText2Cube.AutoSize = true;
            this.lblText2Cube.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2Cube.Location = new System.Drawing.Point(1361, 291);
            this.lblText2Cube.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText2Cube.Name = "lblText2Cube";
            this.lblText2Cube.Size = new System.Drawing.Size(150, 31);
            this.lblText2Cube.TabIndex = 2;
            this.lblText2Cube.Text = "TEXT 2 CUBE";
            // 
            // lblAudioVis
            // 
            this.lblAudioVis.AutoSize = true;
            this.lblAudioVis.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudioVis.Location = new System.Drawing.Point(780, 615);
            this.lblAudioVis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAudioVis.Name = "lblAudioVis";
            this.lblAudioVis.Size = new System.Drawing.Size(221, 31);
            this.lblAudioVis.TabIndex = 2;
            this.lblAudioVis.Text = "AUDIO VISUALIZER";
            // 
            // lblPreset
            // 
            this.lblPreset.AutoSize = true;
            this.lblPreset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreset.Location = new System.Drawing.Point(172, 1009);
            this.lblPreset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreset.Name = "lblPreset";
            this.lblPreset.Size = new System.Drawing.Size(106, 31);
            this.lblPreset.TabIndex = 2;
            this.lblPreset.Text = "PRESETS";
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGames.Location = new System.Drawing.Point(1367, 1009);
            this.lblGames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(93, 31);
            this.lblGames.TabIndex = 2;
            this.lblGames.Text = "GAMES";
            // 
            // btnFreeDraw
            // 
            this.btnFreeDraw.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFreeDraw.FlatAppearance.BorderSize = 0;
            this.btnFreeDraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnFreeDraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFreeDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFreeDraw.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreeDraw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFreeDraw.Location = new System.Drawing.Point(178, 132);
            this.btnFreeDraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFreeDraw.Name = "btnFreeDraw";
            this.btnFreeDraw.Size = new System.Drawing.Size(375, 154);
            this.btnFreeDraw.TabIndex = 4;
            this.btnFreeDraw.UseVisualStyleBackColor = false;
            this.btnFreeDraw.Click += new System.EventHandler(this.btnFreeDraw_Click);
            // 
            // btnText2Cube
            // 
            this.btnText2Cube.BackColor = System.Drawing.Color.SteelBlue;
            this.btnText2Cube.FlatAppearance.BorderSize = 0;
            this.btnText2Cube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnText2Cube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnText2Cube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnText2Cube.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnText2Cube.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnText2Cube.Location = new System.Drawing.Point(1367, 132);
            this.btnText2Cube.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnText2Cube.Name = "btnText2Cube";
            this.btnText2Cube.Size = new System.Drawing.Size(375, 154);
            this.btnText2Cube.TabIndex = 4;
            this.btnText2Cube.UseVisualStyleBackColor = false;
            this.btnText2Cube.Click += new System.EventHandler(this.btnText2Cube_Click);
            // 
            // btnAudioVis
            // 
            this.btnAudioVis.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAudioVis.FlatAppearance.BorderSize = 0;
            this.btnAudioVis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnAudioVis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAudioVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudioVis.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudioVis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAudioVis.Location = new System.Drawing.Point(786, 457);
            this.btnAudioVis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAudioVis.Name = "btnAudioVis";
            this.btnAudioVis.Size = new System.Drawing.Size(375, 154);
            this.btnAudioVis.TabIndex = 4;
            this.btnAudioVis.UseVisualStyleBackColor = false;
            this.btnAudioVis.Click += new System.EventHandler(this.btnAudioVis_Click);
            // 
            // btnGames
            // 
            this.btnGames.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGames.FlatAppearance.BorderSize = 0;
            this.btnGames.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnGames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGames.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGames.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGames.Location = new System.Drawing.Point(1373, 851);
            this.btnGames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(375, 154);
            this.btnGames.TabIndex = 4;
            this.btnGames.UseVisualStyleBackColor = false;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnPresets
            // 
            this.btnPresets.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPresets.FlatAppearance.BorderSize = 0;
            this.btnPresets.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnPresets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPresets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresets.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresets.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPresets.Location = new System.Drawing.Point(178, 851);
            this.btnPresets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPresets.Name = "btnPresets";
            this.btnPresets.Size = new System.Drawing.Size(375, 154);
            this.btnPresets.TabIndex = 4;
            this.btnPresets.UseVisualStyleBackColor = false;
            this.btnPresets.Click += new System.EventHandler(this.btnPresets_Click);
            // 
            // MainMenuTimer
            // 
            this.MainMenuTimer.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuTimer.Location = new System.Drawing.Point(4, 1142);
            this.MainMenuTimer.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MainMenuTimer.Name = "MainMenuTimer";
            this.MainMenuTimer.Size = new System.Drawing.Size(45, 46);
            this.MainMenuTimer.TabIndex = 3;
            // 
            // btnCloseWindow1
            // 
            this.btnCloseWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCloseWindow1.Location = new System.Drawing.Point(1860, 17);
            this.btnCloseWindow1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCloseWindow1.Name = "btnCloseWindow1";
            this.btnCloseWindow1.Size = new System.Drawing.Size(45, 46);
            this.btnCloseWindow1.TabIndex = 0;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnPresets);
            this.Controls.Add(this.btnGames);
            this.Controls.Add(this.btnAudioVis);
            this.Controls.Add(this.btnText2Cube);
            this.Controls.Add(this.btnFreeDraw);
            this.Controls.Add(this.MainMenuTimer);
            this.Controls.Add(this.lblPreset);
            this.Controls.Add(this.lblAudioVis);
            this.Controls.Add(this.lblGames);
            this.Controls.Add(this.lblText2Cube);
            this.Controls.Add(this.lblFreeDraw);
            this.Controls.Add(this.btnCloseWindow1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main Menu";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMainMenu_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btnCloseWindow btnCloseWindow1;
        private System.Windows.Forms.Label lblFreeDraw;
        private System.Windows.Forms.Label lblText2Cube;
        private System.Windows.Forms.Label lblAudioVis;
        private System.Windows.Forms.Label lblPreset;
        private System.Windows.Forms.Label lblGames;
        private ctrlTimer MainMenuTimer;
        private System.Windows.Forms.Button btnFreeDraw;
        private System.Windows.Forms.Button btnText2Cube;
        private System.Windows.Forms.Button btnAudioVis;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Button btnPresets;

    }
}