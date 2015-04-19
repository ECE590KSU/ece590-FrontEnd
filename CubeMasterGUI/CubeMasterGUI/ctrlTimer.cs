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
        private System.Windows.Forms.Timer _inactiveTimer { get; set; }
        private System.Windows.Forms.Timer _userKickTimer { get; set; }
        private int _userKickCounter { get; set; }

        private AutoCloseMessageBox _areYouDonePrompt { get; set; }

        // 8 minute Timeout interval for Inactive. 
        private int _inactiveTimeOut = 50000;
        // 1 Second tick interval for UserKick. After UserKickMAX ticks are reached, 
        // timer stops and logic follows.
        private int _userKickInterval = 1000;
        // Maximum ticks of the user Kick, i.e., number of seconds until kick.   
        private int _userKickMaxTicks = 30;

        public ctrlTimer()
        {
            InitializeComponent();
        }

        public void InitializeTimers()
        {
            _areYouDonePrompt = new AutoCloseMessageBox(_userKickInterval * _userKickMaxTicks);

            _userKickCounter = 0;

            _inactiveTimer = new System.Windows.Forms.Timer();
            _userKickTimer = new System.Windows.Forms.Timer();

            _inactiveTimer.Interval = _inactiveTimeOut;
            _userKickTimer.Interval = _userKickInterval;

            _inactiveTimer.Tick += InactiveTimer_Tick;
            _userKickTimer.Tick += PromptTimer_Tick;

            _inactiveTimer.Start();
        }

        private void InactiveTimer_Tick(object sender, EventArgs e)
        {
            _inactiveTimer.Stop();
            this.PromptIfDone();
        }

        private void PromptTimer_Tick(object sender, EventArgs e)
        {
            if (_userKickCounter++ < _userKickMaxTicks)
            {
                _areYouDonePrompt.TimeLeftText((_userKickMaxTicks-_userKickCounter)*_userKickInterval);
            }
            else
            {
                _userKickTimer.Stop();
                _userKickCounter = 0;
                _areYouDonePrompt.Hide();
                this.ParentForm.Close();
            }
        }

        private void PromptIfDone()
        {
            _userKickTimer.Start();
            _areYouDonePrompt.BringToFront();
            _areYouDonePrompt.TimeLeftText(_userKickMaxTicks * _userKickInterval);

            DialogResult donePrompt = _areYouDonePrompt.ShowDialog();
            if (donePrompt == DialogResult.Yes)
            {
                _userKickTimer.Stop();
                this.ParentForm.Close();
            }
            else if (donePrompt == DialogResult.No)
            {
                _userKickTimer.Stop();
                this.ResetTimers();
            }
        }

        internal void ResetTimers()
        {
            _inactiveTimer.Stop();
            _inactiveTimer.Start();
            _userKickCounter = 0;
        }

        // When a timer exits focus, you'll want to stop all active timers, and
        // wait for the control to regain focus. 
        internal void HaltTimers()
        {
            _userKickTimer.Stop();
            _inactiveTimer.Stop();
        }
    }
}
