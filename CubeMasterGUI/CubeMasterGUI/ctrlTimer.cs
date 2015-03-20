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
        private System.Windows.Forms.Timer UserKickTimer { get; set; }
        private int UserKickCounter { get; set; }

        private AutoCloseMessageBox AreYouDonePrompt { get; set; }

        // 60 Second Timeout interval for Inactive. 
        private int InactiveTimeOut = 3000;
        // 1 Second tick interval for UserKick. After UserKickMAX ticks are reached, 
        // timer stops and logic follows.
        private int UserKickInterval = 1000;
        // Maximum ticks of the user Kick.  
        private int UserKickMAX = 30;

        public ctrlTimer()
        {
            InitializeComponent();
        }

        public void InitializeTimers()
        {
            AreYouDonePrompt = new AutoCloseMessageBox(UserKickInterval * UserKickMAX);

            UserKickCounter = 0;

            InactiveTimer = new System.Windows.Forms.Timer();
            UserKickTimer = new System.Windows.Forms.Timer();

            InactiveTimer.Interval = InactiveTimeOut;
            UserKickTimer.Interval = UserKickInterval;

            InactiveTimer.Tick += InactiveTimer_Tick;
            UserKickTimer.Tick += PromptTimer_Tick;

            InactiveTimer.Start();
        }

        private void InactiveTimer_Tick(object sender, EventArgs e)
        {
            InactiveTimer.Stop();
            this.PromptIfDone();
        }

        private void PromptTimer_Tick(object sender, EventArgs e)
        {
            if (UserKickCounter++ < UserKickMAX)
            {
                AreYouDonePrompt.TimeLeftText((UserKickMAX-UserKickCounter)*UserKickInterval);
            }
            else
            {
                UserKickTimer.Stop();
                UserKickCounter = 0;
                AreYouDonePrompt.Hide();
                this.ParentForm.Close();
            }
        }

        private void PromptIfDone()
        {
            UserKickTimer.Start();
            AreYouDonePrompt.BringToFront();
            AreYouDonePrompt.TimeLeftText(UserKickMAX * UserKickInterval);

            DialogResult donePrompt = AreYouDonePrompt.ShowDialog();
            if (donePrompt == DialogResult.Yes)
            {
                UserKickTimer.Stop();
                this.ParentForm.Close();
            }
            else if (donePrompt == DialogResult.No)
            {
                UserKickTimer.Stop();
                this.ResetTimers();
            }
        }

        internal void ResetTimers()
        {
            InactiveTimer.Stop();
            InactiveTimer.Start();
            UserKickCounter = 0;
        }
    }
}
