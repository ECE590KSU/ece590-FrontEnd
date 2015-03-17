using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeMasterGUI
{
    public partial class ctrlTimer : UserControl
    {
        private System.Windows.Forms.Timer InactiveTimer { get; set; }
        private System.Windows.Forms.Timer PromptTimer { get; set; }
        private System.Windows.Forms.Form ParentFormReference { get; set; }

        public ctrlTimer()
        {
            InitializeComponent();
        }

        public void InitializeTimers(Form parentform)
        {
            ParentFormReference = parentform;

            InactiveTimer = new System.Windows.Forms.Timer();
            PromptTimer = new System.Windows.Forms.Timer();

            InactiveTimer.Interval = AssetHandler.InactiveTimeOut;
            PromptTimer.Interval = AssetHandler.PromptTimeOut;

            InactiveTimer.Tick += InactiveTimer_Tick;
            PromptTimer.Tick += PromptTimer_Tick;

            InactiveTimer.Start();
        }

        private void InactiveTimer_Tick(object sender, EventArgs e)
        {
            InactiveTimer.Stop();
            this.PromptIfDone();
        }

        private void PromptTimer_Tick(object sender, EventArgs e)
        {
            PromptTimer.Stop();
            this.ParentFormReference.Close();
        }

        private void PromptIfDone()
        {
            PromptTimer.Start();
            AutoCloseMessageBox closePrompt = new AutoCloseMessageBox();
            closePrompt.Location = this.ParentFormReference.Location;
            closePrompt.BringToFront();
            closePrompt.Show();
        }
    }
}
