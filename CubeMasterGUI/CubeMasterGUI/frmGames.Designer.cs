namespace CubeMasterGUI
{
    partial class frmGames
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
            this.btnSnake = new System.Windows.Forms.Button();
            this.btnCatcher = new System.Windows.Forms.Button();
            this.btnCloseWindow1 = new CubeMasterGUI.btnCloseWindow();
            this.tmrGames = new CubeMasterGUI.ctrlTimer();
            this.SuspendLayout();
            // 
            // lblWindowName
            // 
            this.lblWindowName.AutoSize = true;
            this.lblWindowName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindowName.Location = new System.Drawing.Point(13, 13);
            this.lblWindowName.Name = "lblWindowName";
            this.lblWindowName.Size = new System.Drawing.Size(0, 25);
            this.lblWindowName.TabIndex = 1;
            // 
            // btnSnake
            // 
            this.btnSnake.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSnake.FlatAppearance.BorderSize = 0;
            this.btnSnake.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnSnake.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSnake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnake.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnake.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSnake.Location = new System.Drawing.Point(381, 299);
            this.btnSnake.Name = "btnSnake";
            this.btnSnake.Size = new System.Drawing.Size(238, 62);
            this.btnSnake.TabIndex = 4;
            this.btnSnake.Text = "SNAKE";
            this.btnSnake.UseVisualStyleBackColor = false;
            this.btnSnake.Click += new System.EventHandler(this.btnSnake_Click);
            // 
            // btnCatcher
            // 
            this.btnCatcher.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCatcher.FlatAppearance.BorderSize = 0;
            this.btnCatcher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCatcher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCatcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatcher.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatcher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatcher.Location = new System.Drawing.Point(691, 299);
            this.btnCatcher.Name = "btnCatcher";
            this.btnCatcher.Size = new System.Drawing.Size(238, 62);
            this.btnCatcher.TabIndex = 5;
            this.btnCatcher.Text = "CATCHER";
            this.btnCatcher.UseVisualStyleBackColor = false;
            this.btnCatcher.Click += new System.EventHandler(this.btnCatcher_Click);
            // 
            // btnCloseWindow1
            // 
            this.btnCloseWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCloseWindow1.Location = new System.Drawing.Point(1323, 13);
            this.btnCloseWindow1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCloseWindow1.Name = "btnCloseWindow1";
            this.btnCloseWindow1.Size = new System.Drawing.Size(30, 30);
            this.btnCloseWindow1.TabIndex = 0;
            // 
            // tmrGames
            // 
            this.tmrGames.BackColor = System.Drawing.Color.Transparent;
            this.tmrGames.Location = new System.Drawing.Point(0, 690);
            this.tmrGames.Name = "tmrGames";
            this.tmrGames.Size = new System.Drawing.Size(13, 13);
            this.tmrGames.TabIndex = 3;
            // 
            // frmGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnCatcher);
            this.Controls.Add(this.btnSnake);
            this.Controls.Add(this.lblWindowName);
            this.Controls.Add(this.btnCloseWindow1);
            this.Controls.Add(this.tmrGames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGames";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmGames_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmGames_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btnCloseWindow btnCloseWindow1;
        private System.Windows.Forms.Label lblWindowName;
        private ctrlTimer tmrGames;
        private System.Windows.Forms.Button btnSnake;
        private System.Windows.Forms.Button btnCatcher;
    }
}