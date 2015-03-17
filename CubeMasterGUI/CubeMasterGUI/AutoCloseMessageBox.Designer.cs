namespace CubeMasterGUI
{
    partial class AutoCloseMessageBox
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
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.lblClosing = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.SteelBlue;
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYes.Location = new System.Drawing.Point(43, 91);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(130, 80);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNo.Location = new System.Drawing.Point(215, 91);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(130, 80);
            this.btnNo.TabIndex = 0;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(38, 33);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(184, 30);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "Are you finished?";
            // 
            // lblClosing
            // 
            this.lblClosing.AutoSize = true;
            this.lblClosing.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosing.Location = new System.Drawing.Point(38, 193);
            this.lblClosing.Name = "lblClosing";
            this.lblClosing.Size = new System.Drawing.Size(129, 30);
            this.lblClosing.TabIndex = 1;
            this.lblClosing.Text = "Closing in...";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(210, 197);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(0, 25);
            this.lblTimeLeft.TabIndex = 2;
            // 
            // AutoCloseMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblClosing);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Name = "AutoCloseMessageBox";
            this.Size = new System.Drawing.Size(400, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Label lblClosing;
        private System.Windows.Forms.Label lblTimeLeft;
    }
}
