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
        /// <summary>
        /// A timer to monitor the number of passed seconds due to user inactivity.
        /// </summary>
        private System.Windows.Forms.Timer _inactiveTimer { get; set; }

        /// <summary>
        /// A timer to control the countdown of the AutoCloseMessageBox.
        /// </summary>
        private System.Windows.Forms.Timer _userKickTimer { get; set; }

        /// <summary>
        /// Counter to update the countdown timer and display it to the user.
        /// </summary>
        private int _userKickCounter { get; set; }

        /// <summary>
        /// An window that passively checks for user inactivity.
        /// </summary>
        private AutoCloseMessageBox _areYouDonePrompt { get; set; }

        /// <summary>
        /// Divide by 1000 to get number of seconds before user is considered inactive.
        /// </summary>
        private int _inactiveTimeOut = 50000;

        /// <summary>
        /// Single second ticks between each update of the user kick prompt (AutoCloseMessageBox).
        /// </summary>
        private int _userKickInterval = 1000;

        /// <summary>
        /// Maximum number of times the _userKickTimer interval will be handled, i.e., the
        /// number of seconds until user is kicked from form. 
        /// </summary>
        private int _userKickMaxTicks = 30;

        /// <summary>
        /// Public, default constructor for an instance of the ctrlTimer object.
        /// </summary>
        public ctrlTimer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Non-default public constructor. Allows user to set their own kick timeout,
        /// which is very useful for various games and drawing functions that may require a large
        /// amount of user inactivity.
        /// </summary>
        /// <param name="timeout"></param>
        public ctrlTimer(int timeout)
        {
            _inactiveTimeOut = timeout;
        }

        /// <summary>
        /// Initializes the timers used, and sets the _areYouDonePrompt properties. Starts the timers.
        /// </summary>
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

        /// <summary>
        /// Changes the _inactiveTimer.Interval. 
        /// </summary>
        /// <param name="seconds"></param>
        public void ChangeInactiveTimeout(int seconds)
        {
            _inactiveTimer.Stop();
            _inactiveTimer.Dispose();
            this._inactiveTimeOut = seconds * 1000;

            InitializeTimers();
        }

        /// <summary>
        /// A single tick of the _inactiveTimer. Only one tick will be handled, and
        /// then the PromptIfDone() must be invoked. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InactiveTimer_Tick(object sender, EventArgs e)
        {
            _inactiveTimer.Stop();
            this.PromptIfDone();
        }

        /// <summary>
        /// Update _userKickCounter and the _areYouDonePrompt text field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Display the AutoCloseMessageBox (_areYouDonePrompt) to the user and countdown
        /// until they are kicked due to inactivity. 
        /// </summary>
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

        /// <summary>
        /// Reset the timers.
        /// </summary>
        internal void ResetTimers()
        {
            _inactiveTimer.Stop();
            _inactiveTimer.Start();
            _userKickCounter = 0;
        }

        /// <summary>
        /// When a timer exits focus, you'll want to stop all active timers, and
        /// wait for the control to regain focus. 
        /// </summary>
        internal void HaltTimers()
        {
            _userKickTimer.Stop();
            _inactiveTimer.Stop();
        }
    }
}
