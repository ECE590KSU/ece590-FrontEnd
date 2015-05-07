using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeMasterGUI
{
    public partial class frmTextToCube : Form
    {
        /// <summary>
        /// The controller for this form
        /// </summary>
        private TextToCube _textToCubeController;
        
        /// <summary>
        /// Regex for blocking out vulgar languague
        /// </summary>
        private const string regex = @".*\b(hell(?!o)|shit|shitface|fuck|shitty|damn|darn|damnit|b.tch|crap|fag|fagg.t|bast.rd|slut|slutty|douche|cum(?!mings)|jizz|dick|pussy|piss|cock|cunt|whore|asshole|nigger|nigga).*";

        /// <summary>
        /// Constructor for text to cube form
        /// </summary>
        /// <param name="cube"></param>
        /// <param name="parentWidth"></param>
        /// <param name="parentHeight"></param>
        public frmTextToCube(ref CubeController.Cube cube, int parentWidth, int parentHeight)
        {
            InitializeComponent();
            _textToCubeController = new TextToCube(ref cube);

            this.Width = parentWidth;
            this.Height = parentHeight;

            AssignEventHandlers();
            InvokeTimerProtocol();
            InitializeRadioButtons();

            this.btnCloseWindow.BringToFront();
        }

        /// <summary>
        /// Clears the text box on a btnClear click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxMessage.Text = "";
        }

        /// <summary>
        /// Handles a btnSend Click event. It checks the message
        /// length and ensures that it does not contain vulgar
        /// language before sending the message to the cube.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            string text = txtBoxMessage.Text;
            Match match = Regex.Match(text, regex, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                MessageBox.Show("Inappropriate language detected. Please enter another phrase.");
                txtBoxMessage.Text = "";
            }
            else if (text.Length > 60)
            {
                MessageBox.Show("Message is too long. Please enter another phrase less than 60 characters.");
                txtBoxMessage.Text = "";
            }
            else
            {
                _textToCubeController.SendMessage(text);
            }
        }

        /// <summary>
        /// Changes the text display effect to the selected option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EffectStyleButtonCheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            if (btn.Checked)
            {
                _textToCubeController.SelectedTextEffectChanged(btn.Name);
            }
        }

        /// <summary>
        /// Initializes the timer
        /// </summary>
        private void InvokeTimerProtocol()
        {
            this.tmrTextToCube.InitializeTimers();
        }

        /// <summary>
        /// Initializes the radio buttons
        /// </summary>
        private void InitializeRadioButtons()
        {
            btnBackToFront.Checked = true;
        }

        /// <summary>
        /// Handles a mouse click event to reset timers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_MouseClick(object sender, MouseEventArgs e)
        {
            tmrTextToCube.ResetTimers();
        }

        /// <summary>
        /// Handles a mouse move event to reset timers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_MouseMove(object sender, MouseEventArgs e)
        {
            tmrTextToCube.ResetTimers();
        }

        /// <summary>
        /// Assigns Event Handlers
        /// </summary>
        private void AssignEventHandlers()
        {
            btnBackToFront.CheckedChanged += EffectStyleButtonCheckedChanged;
            btnFrontToBack.CheckedChanged += EffectStyleButtonCheckedChanged;
            btnClockwiseBanner.CheckedChanged += EffectStyleButtonCheckedChanged;
            btnCounterclockwiseBanner.CheckedChanged += EffectStyleButtonCheckedChanged;
            btnSpin3D.CheckedChanged += EffectStyleButtonCheckedChanged;
        }
    }
}
