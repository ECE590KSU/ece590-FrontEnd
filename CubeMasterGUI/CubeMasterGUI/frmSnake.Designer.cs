namespace CubeMasterGUI
{
    partial class frmSnake
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
            this.pnlDrawingControls = new System.Windows.Forms.Panel();
            this.btnHard = new System.Windows.Forms.RadioButton();
            this.btnMedium = new System.Windows.Forms.RadioButton();
            this.btnEasy = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.listBoxHighScores = new System.Windows.Forms.ListBox();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnCloseWindow1 = new CubeMasterGUI.btnCloseWindow();
            this.tmrSnake = new CubeMasterGUI.ctrlTimer();
            this.pnlDrawingControls.SuspendLayout();
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
            // pnlDrawingControls
            // 
            this.pnlDrawingControls.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlDrawingControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawingControls.Controls.Add(this.btnHard);
            this.pnlDrawingControls.Controls.Add(this.btnMedium);
            this.pnlDrawingControls.Controls.Add(this.btnEasy);
            this.pnlDrawingControls.ForeColor = System.Drawing.Color.SteelBlue;
            this.pnlDrawingControls.Location = new System.Drawing.Point(934, 419);
            this.pnlDrawingControls.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDrawingControls.Name = "pnlDrawingControls";
            this.pnlDrawingControls.Size = new System.Drawing.Size(151, 135);
            this.pnlDrawingControls.TabIndex = 5;
            // 
            // btnHard
            // 
            this.btnHard.AutoSize = true;
            this.btnHard.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(9, 81);
            this.btnHard.Margin = new System.Windows.Forms.Padding(2);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(89, 36);
            this.btnHard.TabIndex = 0;
            this.btnHard.TabStop = true;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnHard_KeyDown);
            // 
            // btnMedium
            // 
            this.btnMedium.AutoSize = true;
            this.btnMedium.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.Location = new System.Drawing.Point(9, 45);
            this.btnMedium.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(128, 36);
            this.btnMedium.TabIndex = 0;
            this.btnMedium.TabStop = true;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnMedium_KeyDown);
            // 
            // btnEasy
            // 
            this.btnEasy.AutoSize = true;
            this.btnEasy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.Location = new System.Drawing.Point(9, 10);
            this.btnEasy.Margin = new System.Windows.Forms.Padding(2);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(83, 36);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEasy_KeyDown);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(934, 559);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(151, 48);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEndGame
            // 
            this.btnEndGame.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEndGame.FlatAppearance.BorderSize = 0;
            this.btnEndGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnEndGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEndGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndGame.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEndGame.Location = new System.Drawing.Point(934, 610);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(151, 48);
            this.btnEndGame.TabIndex = 8;
            this.btnEndGame.Text = "END GAME";
            this.btnEndGame.UseVisualStyleBackColor = false;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // listBoxHighScores
            // 
            this.listBoxHighScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxHighScores.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHighScores.ForeColor = System.Drawing.Color.SteelBlue;
            this.listBoxHighScores.FormattingEnabled = true;
            this.listBoxHighScores.ItemHeight = 30;
            this.listBoxHighScores.Location = new System.Drawing.Point(934, 142);
            this.listBoxHighScores.Name = "listBoxHighScores";
            this.listBoxHighScores.Size = new System.Drawing.Size(153, 242);
            this.listBoxHighScores.TabIndex = 9;
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHighScore.Location = new System.Drawing.Point(929, 109);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(128, 30);
            this.lblHighScore.TabIndex = 10;
            this.lblHighScore.Text = "High Scores:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblScore.Location = new System.Drawing.Point(929, 387);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(69, 30);
            this.lblScore.TabIndex = 11;
            this.lblScore.Text = "Score:";
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
            // tmrSnake
            // 
            this.tmrSnake.BackColor = System.Drawing.Color.Transparent;
            this.tmrSnake.Location = new System.Drawing.Point(0, 690);
            this.tmrSnake.Name = "tmrSnake";
            this.tmrSnake.Size = new System.Drawing.Size(13, 13);
            this.tmrSnake.TabIndex = 3;
            // 
            // frmSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.listBoxHighScores);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlDrawingControls);
            this.Controls.Add(this.lblWindowName);
            this.Controls.Add(this.btnCloseWindow1);
            this.Controls.Add(this.tmrSnake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmSnake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSnake";
            this.Load += new System.EventHandler(this.frmSnake_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmSnake_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmSnake_MouseMove);
            this.pnlDrawingControls.ResumeLayout(false);
            this.pnlDrawingControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btnCloseWindow btnCloseWindow1;
        private System.Windows.Forms.Label lblWindowName;
        private ctrlTimer tmrSnake;
        private System.Windows.Forms.Panel pnlDrawingControls;
        private System.Windows.Forms.RadioButton btnHard;
        private System.Windows.Forms.RadioButton btnMedium;
        private System.Windows.Forms.RadioButton btnEasy;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.ListBox listBoxHighScores;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblScore;
    }
}