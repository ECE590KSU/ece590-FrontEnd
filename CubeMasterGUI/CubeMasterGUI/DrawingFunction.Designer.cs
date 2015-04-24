namespace CubeMasterGUI
{
    partial class DrawingFunction
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
            this.btnFunction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFunction
            // 
            this.btnFunction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunction.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunction.Location = new System.Drawing.Point(0, 0);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(150, 150);
            this.btnFunction.TabIndex = 0;
            this.btnFunction.Text = "button1";
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Click += new System.EventHandler(this.DrawingFunction_Click);
            // 
            // DrawingFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFunction);
            this.Name = "DrawingFunction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFunction;
    }
}
