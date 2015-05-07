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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTextToCube));
            this.pnlDrawingControls = new System.Windows.Forms.Panel();
            this.btnSpin3D = new System.Windows.Forms.RadioButton();
            this.btnCounterclockwiseBanner = new System.Windows.Forms.RadioButton();
            this.btnClockwiseBanner = new System.Windows.Forms.RadioButton();
            this.btnBackToFront = new System.Windows.Forms.RadioButton();
            this.btnFrontToBack = new System.Windows.Forms.RadioButton();
            this.txtBoxMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCloseWindow2 = new CubeMasterGUI.btnCloseWindow();
            this.btnCloseWindow1 = new CubeMasterGUI.btnCloseWindow();
            this.tmrTextToCube = new CubeMasterGUI.ctrlTimer();
            this.btnCloseWindow = new CubeMasterGUI.btnCloseWindow();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarDelay = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseWindow3 = new CubeMasterGUI.btnCloseWindow();
            this.pnlDrawingControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDrawingControls
            // 
            this.pnlDrawingControls.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDrawingControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawingControls.Controls.Add(this.btnSpin3D);
            this.pnlDrawingControls.Controls.Add(this.btnCounterclockwiseBanner);
            this.pnlDrawingControls.Controls.Add(this.btnClockwiseBanner);
            this.pnlDrawingControls.Controls.Add(this.btnBackToFront);
            this.pnlDrawingControls.Controls.Add(this.btnFrontToBack);
            this.pnlDrawingControls.ForeColor = System.Drawing.Color.SteelBlue;
            this.pnlDrawingControls.Location = new System.Drawing.Point(793, 144);
            this.pnlDrawingControls.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDrawingControls.Name = "pnlDrawingControls";
            this.pnlDrawingControls.Size = new System.Drawing.Size(335, 217);
            this.pnlDrawingControls.TabIndex = 5;
            // 
            // btnSpin3D
            // 
            this.btnSpin3D.AutoSize = true;
            this.btnSpin3D.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin3D.Location = new System.Drawing.Point(9, 161);
            this.btnSpin3D.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpin3D.Name = "btnSpin3D";
            this.btnSpin3D.Size = new System.Drawing.Size(122, 36);
            this.btnSpin3D.TabIndex = 2;
            this.btnSpin3D.Text = "3D Spin";
            this.btnSpin3D.UseVisualStyleBackColor = true;
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
            this.btnBackToFront.Location = new System.Drawing.Point(9, 2);
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
            this.btnFrontToBack.Location = new System.Drawing.Point(9, 39);
            this.btnFrontToBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnFrontToBack.Name = "btnFrontToBack";
            this.btnFrontToBack.Size = new System.Drawing.Size(190, 36);
            this.btnFrontToBack.TabIndex = 0;
            this.btnFrontToBack.Text = "Front To Back";
            this.btnFrontToBack.UseVisualStyleBackColor = true;
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtBoxMessage.Location = new System.Drawing.Point(793, 395);
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.Size = new System.Drawing.Size(335, 35);
            this.txtBoxMessage.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnSend.Location = new System.Drawing.Point(793, 436);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(153, 37);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSend_MouseClick);
            this.btnSend.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSend_MouseMove);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnClear.Location = new System.Drawing.Point(972, 436);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(153, 37);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(788, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 96);
            this.label2.TabIndex = 12;
            this.label2.Text = "Send a short message to the cube.\r\nRemember, only one layer is ever\r\non at a give" +
    "n time!\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(788, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Text Display Style:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(788, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Message to Send:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "How It Works:";
            // 
            // btnCloseWindow2
            // 
            this.btnCloseWindow2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCloseWindow2.Location = new System.Drawing.Point(3300, 36);
            this.btnCloseWindow2.Margin = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.btnCloseWindow2.Name = "btnCloseWindow2";
            this.btnCloseWindow2.Size = new System.Drawing.Size(75, 65);
            this.btnCloseWindow2.TabIndex = 13;
            // 
            // btnCloseWindow1
            // 
            this.btnCloseWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCloseWindow1.Location = new System.Drawing.Point(8270, 69);
            this.btnCloseWindow1.Margin = new System.Windows.Forms.Padding(25);
            this.btnCloseWindow1.Name = "btnCloseWindow1";
            this.btnCloseWindow1.Size = new System.Drawing.Size(188, 149);
            this.btnCloseWindow1.TabIndex = 11;
            // 
            // tmrTextToCube
            // 
            this.tmrTextToCube.BackColor = System.Drawing.Color.Transparent;
            this.tmrTextToCube.Location = new System.Drawing.Point(425, 3502);
            this.tmrTextToCube.Margin = new System.Windows.Forms.Padding(50, 36, 50, 36);
            this.tmrTextToCube.Name = "tmrTextToCube";
            this.tmrTextToCube.Size = new System.Drawing.Size(188, 149);
            this.tmrTextToCube.TabIndex = 10;
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCloseWindow.Location = new System.Drawing.Point(32736, 323);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(155, 125, 155, 125);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(1175, 741);
            this.btnCloseWindow.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(369, 144);
            this.label5.TabIndex = 16;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // trackBarDelay
            // 
            this.trackBarDelay.Location = new System.Drawing.Point(161, 316);
            this.trackBarDelay.Name = "trackBarDelay";
            this.trackBarDelay.Size = new System.Drawing.Size(365, 45);
            this.trackBarDelay.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 144);
            this.label6.TabIndex = 18;
            this.label6.Text = "Use this track bar to change how fast\r\nthe cube change between layers.\r\nNotice ho" +
    "w is goes from one layer on\r\nat a time to appearing as if the entire\r\ncube is il" +
    "luminated?\r\n\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(156, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Slow";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(491, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fast";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(148, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 67);
            this.panel1.TabIndex = 21;
            // 
            // btnCloseWindow3
            // 
            this.btnCloseWindow3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCloseWindow3.Location = new System.Drawing.Point(1319, 16);
            this.btnCloseWindow3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCloseWindow3.Name = "btnCloseWindow3";
            this.btnCloseWindow3.Size = new System.Drawing.Size(30, 30);
            this.btnCloseWindow3.TabIndex = 22;
            // 
            // frmTextToCube
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1366, 750);
            this.Controls.Add(this.btnCloseWindow3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBarDelay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCloseWindow2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCloseWindow1);
            this.Controls.Add(this.tmrTextToCube);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBoxMessage);
            this.Controls.Add(this.pnlDrawingControls);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTextToCube";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTextToCube";
            this.pnlDrawingControls.ResumeLayout(false);
            this.pnlDrawingControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelay)).EndInit();
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


        private System.Windows.Forms.RadioButton btnSpin3D;
        private ctrlTimer tmrTextToCube;
        private btnCloseWindow btnCloseWindow1;
        private System.Windows.Forms.Label label2;
        private btnCloseWindow btnCloseWindow2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarDelay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private btnCloseWindow btnCloseWindow3;

    }
}