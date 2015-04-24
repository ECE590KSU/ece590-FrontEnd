namespace CubeMasterGUI
{
    partial class frmTextToCube
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
            this.btnCloseWindow = new CubeMasterGUI.btnCloseWindow();
            this.pnlDrawingControls = new System.Windows.Forms.Panel();
            this.btnClockwiseBanner = new System.Windows.Forms.RadioButton();
            this.btnBackToFront = new System.Windows.Forms.RadioButton();
            this.btnFrontToBack = new System.Windows.Forms.RadioButton();
            this.btnCounterclockwiseBanner = new System.Windows.Forms.RadioButton();
            this.txtBoxMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDrawingControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCloseWindow.Location = new System.Drawing.Point(1323, 13);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(30, 30);
            this.btnCloseWindow.TabIndex = 1;
            // 
            // pnlDrawingControls
            // 
            this.pnlDrawingControls.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDrawingControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawingControls.Controls.Add(this.btnCounterclockwiseBanner);
            this.pnlDrawingControls.Controls.Add(this.btnClockwiseBanner);
            this.pnlDrawingControls.Controls.Add(this.btnBackToFront);
            this.pnlDrawingControls.Controls.Add(this.btnFrontToBack);
            this.pnlDrawingControls.ForeColor = System.Drawing.Color.SteelBlue;
            this.pnlDrawingControls.Location = new System.Drawing.Point(260, 164);
            this.pnlDrawingControls.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDrawingControls.Name = "pnlDrawingControls";
            this.pnlDrawingControls.Size = new System.Drawing.Size(335, 172);
            this.pnlDrawingControls.TabIndex = 5;
            // 
            // btnClockwiseBanner
            // 
            this.btnClockwiseBanner.AutoSize = true;
            this.btnClockwiseBanner.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClockwiseBanner.Location = new System.Drawing.Point(9, 81);
            this.btnClockwiseBanner.Margin = new System.Windows.Forms.Padding(2);
            this.btnClockwiseBanner.Name = "btnClockwiseBanner";
            this.btnClockwiseBanner.Size = new System.Drawing.Size(233, 36);
            this.btnClockwiseBanner.TabIndex = 0;
            this.btnClockwiseBanner.Text = "Clockwise Banner";
            this.btnClockwiseBanner.UseVisualStyleBackColor = true;
            // 
            // btnBackToFront
            // 
            this.btnBackToFront.AutoSize = true;
            this.btnBackToFront.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToFront.Location = new System.Drawing.Point(9, 45);
            this.btnBackToFront.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackToFront.Name = "btnBackToFront";
            this.btnBackToFront.Size = new System.Drawing.Size(190, 36);
            this.btnBackToFront.TabIndex = 0;
            this.btnBackToFront.Text = "Back To Front";
            this.btnBackToFront.UseVisualStyleBackColor = true;
            // 
            // btnFrontToBack
            // 
            this.btnFrontToBack.AutoSize = true;
            this.btnFrontToBack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrontToBack.Location = new System.Drawing.Point(9, 10);
            this.btnFrontToBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnFrontToBack.Name = "btnFrontToBack";
            this.btnFrontToBack.Size = new System.Drawing.Size(190, 36);
            this.btnFrontToBack.TabIndex = 0;
            this.btnFrontToBack.Text = "Front To Back";
            this.btnFrontToBack.UseVisualStyleBackColor = true;
            // 
            // btnCounterclockwiseBanner
            // 
            this.btnCounterclockwiseBanner.AutoSize = true;
            this.btnCounterclockwiseBanner.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCounterclockwiseBanner.Location = new System.Drawing.Point(9, 121);
            this.btnCounterclockwiseBanner.Margin = new System.Windows.Forms.Padding(2);
            this.btnCounterclockwiseBanner.Name = "btnCounterclockwiseBanner";
            this.btnCounterclockwiseBanner.Size = new System.Drawing.Size(322, 36);
            this.btnCounterclockwiseBanner.TabIndex = 1;
            this.btnCounterclockwiseBanner.Text = "Counterclockwise Banner";
            this.btnCounterclockwiseBanner.UseVisualStyleBackColor = true;
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtBoxMessage.Location = new System.Drawing.Point(641, 210);
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.Size = new System.Drawing.Size(395, 35);
            this.txtBoxMessage.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnSend.Location = new System.Drawing.Point(641, 259);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(168, 37);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnClear.Location = new System.Drawing.Point(868, 259);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(168, 37);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Effect:";
            // 
            // frmTextToCube
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBoxMessage);
            this.Controls.Add(this.pnlDrawingControls);
            this.Controls.Add(this.btnCloseWindow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTextToCube";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTextToCube";
            this.pnlDrawingControls.ResumeLayout(false);
            this.pnlDrawingControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btnCloseWindow btnCloseWindow;
        private System.Windows.Forms.Panel pnlDrawingControls;
        private System.Windows.Forms.RadioButton btnCounterclockwiseBanner;
        private System.Windows.Forms.RadioButton btnClockwiseBanner;
        private System.Windows.Forms.RadioButton btnBackToFront;
        private System.Windows.Forms.RadioButton btnFrontToBack;
        private System.Windows.Forms.TextBox txtBoxMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
    }
}