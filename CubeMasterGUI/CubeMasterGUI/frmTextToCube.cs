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
        private const string regex = @".*\b(hell(?!o)|shit|shitface|fuck|shitty|damn|darn|damnit|b.tch|crap|fag|fagg.t|bast.rd|slut|slutty|douche|cum(?!mings)|jizz|dick|pussy|piss|cock|cunt|whore|asshole|nigger|nigga).*";

        public frmTextToCube()
        {
            InitializeComponent();
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
        }
    }
}
