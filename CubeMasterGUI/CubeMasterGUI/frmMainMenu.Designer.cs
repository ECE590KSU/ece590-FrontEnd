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
            this.lblPreset = new System.Windows.Forms.Label();
            this.lblGames = new System.Windows.Forms.Label();
            this.btnFreeDraw = new System.Windows.Forms.Button();
            this.btnText2Cube = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.btnPresets = new System.Windows.Forms.Button();
            this.tmrMainMenu = new CubeMasterGUI.ctrlTimer();
            this.btnCloseWindow1 = new CubeMasterGUI.btnCloseWindow();
            this.SuspendLayout();
            // 
            // lblFreeDraw
            // 
            this.lblFreeDraw.AutoSize = true;
            this.lblFreeDraw.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreeDraw.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFreeDraw.Location = new System.Drawing.Point(156, 189);
            this.lblFreeDraw.Name = "lblFreeDraw";
            this.lblFreeDraw.Size = new System.Drawing.Size(116, 25);
            this.lblFreeDraw.TabIndex = 2;
            this.lblFreeDraw.Text = "FREE DRAW";
            // 
            // lblText2Cube
            // 
            this.lblText2Cube.AutoSize = true;
            this.lblText2Cube.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2Cube.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblText2Cube.Location = new System.Drawing.Point(842, 201);
            this.lblText2Cube.Name = "lblText2Cube";
            this.lblText2Cube.Size = new System.Drawing.Size(125, 25);
            this.lblText2Cube.TabIndex = 2;
            this.lblText2Cube.Text = "TEXT 2 CUBE";
            // 
            // lblPreset
            // 
            this.lblPreset.AutoSize = true;
            this.lblPreset.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreset.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPreset.Location = new System.Drawing.Point(156, 656);
            this.lblPreset.Name = "lblPreset";
            this.lblPreset.Size = new System.Drawing.Size(89, 25);
            this.lblPreset.TabIndex = 2;
            this.lblPreset.Text = "PRESETS";
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGames.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblGames.Location = new System.Drawing.Point(842, 667);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(78, 25);
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
            this.btnFreeDraw.Location = new System.Drawing.Point(160, 86);
            this.btnFreeDraw.Name = "btnFreeDraw";
            this.btnFreeDraw.Size = new System.Drawing.Size(250, 100);
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
            this.btnText2Cube.Location = new System.Drawing.Point(847, 86);
            this.btnText2Cube.Name = "btnText2Cube";
            this.btnText2Cube.Size = new System.Drawing.Size(250, 100);
            this.btnText2Cube.TabIndex = 4;
            this.btnText2Cube.UseVisualStyleBackColor = false;
            this.btnText2Cube.Click += new System.EventHandler(this.btnText2Cube_Click);
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
            this.btnGames.Location = new System.Drawing.Point(847, 564);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(250, 100);
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
            this.btnPresets.Location = new System.Drawing.Point(160, 553);
            this.btnPresets.Name = "btnPresets";
            this.btnPresets.Size = new System.Drawing.Size(250, 100);
            this.btnPresets.TabIndex = 4;
            this.btnPresets.UseVisualStyleBackColor = false;
            this.btnPresets.Click += new System.EventHandler(this.btnPresets_Click);
            // 
            // tmrMainMenu
            // 
            this.tmrMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.tmrMainMenu.Location = new System.Drawing.Point(44, 742);
            this.tmrMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tmrMainMenu.Name = "tmrMainMenu";
            this.tmrMainMenu.Size = new System.Drawing.Size(30, 30);
            this.tmrMainMenu.TabIndex = 3;
            // 
            // btnCloseWindow1
            // 
            this.btnCloseWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCloseWindow1.Location = new System.Drawing.Point(1323, 14);
            this.btnCloseWindow1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.Controls.Add(this.btnPresets);
            this.Controls.Add(this.btnGames);
            this.Controls.Add(this.btnText2Cube);
            this.Controls.Add(this.btnFreeDraw);
            this.Controls.Add(this.tmrMainMenu);
            this.Controls.Add(this.lblPreset);
            this.Controls.Add(this.lblGames);
            this.Controls.Add(this.lblText2Cube);
            this.Controls.Add(this.lblFreeDraw);
            this.Controls.Add(this.btnCloseWindow1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label lblPreset;
        private System.Windows.Forms.Label lblGames;
        private ctrlTimer tmrMainMenu;
        private System.Windows.Forms.Button btnFreeDraw;
        private System.Windows.Forms.Button btnText2Cube;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Button btnPresets;

    }
}