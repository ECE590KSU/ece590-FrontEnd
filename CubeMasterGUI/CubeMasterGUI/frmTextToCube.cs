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
        private TextToCube _textToCubeController;
        
        private const string regex = @".*\b(hell(?!o)|shit|shitface|fuck|shitty|damn|darn|damnit|b.tch|crap|fag|fagg.t|bast.rd|slut|slutty|douche|cum(?!mings)|jizz|dick|pussy|piss|cock|cunt|whore|asshole|nigger|nigga).*";

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxMessage.Text = "";
        }

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

        private void EffectStyleButtonCheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            if (btn.Checked)
            {
                _textToCubeController.SelectedTextEffectChanged(btn.Name);
            }
        }

        private void InvokeTimerProtocol()
        {
            this.tmrTextToCube.InitializeTimers();
        }

        private void InitializeRadioButtons()
        {
            btnBackToFront.Checked = true;
        }

        private void btnSend_MouseClick(object sender, MouseEventArgs e)
        {
            tmrTextToCube.ResetTimers();
        }

        private void btnSend_MouseMove(object sender, MouseEventArgs e)
        {
            tmrTextToCube.ResetTimers();
        }

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
