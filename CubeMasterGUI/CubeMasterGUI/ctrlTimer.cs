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
        private AutoCloseMessageBox AreYouDonePrompt { get; set; }

        // 60 Second Timeout for Inactive. 
        private int InactiveTimeOut = 3000;
        // 30 Second Timeout for Prompt. 
        private int PromptTimeOut = 30000;

        public ctrlTimer()
        {
            InitializeComponent();
            InitializeTimers();
        }

        public void InitializeTimers()
        {
            AreYouDonePrompt = new AutoCloseMessageBox(PromptTimeOut);

            InactiveTimer = new System.Windows.Forms.Timer();
            PromptTimer = new System.Windows.Forms.Timer();

            InactiveTimer.Interval = InactiveTimeOut;
            PromptTimer.Interval = PromptTimeOut;

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
            AreYouDonePrompt.Hide();
            this.ParentForm.Close();
        }

        private void PromptIfDone()
        {
            PromptTimer.Start();
            AreYouDonePrompt.BringToFront();
            DialogResult donePrompt = AreYouDonePrompt.ShowDialog();
            if (donePrompt == DialogResult.Yes)
            {
                PromptTimer.Stop();
                this.ParentForm.Close();
            }
            else if (donePrompt == DialogResult.No)
            {
                PromptTimer.Stop();
                this.ResetTimers();
            }
        }

        internal void ResetTimers()
        {
            InactiveTimer.Stop();
            InactiveTimer.Start();
        }
    }
}
