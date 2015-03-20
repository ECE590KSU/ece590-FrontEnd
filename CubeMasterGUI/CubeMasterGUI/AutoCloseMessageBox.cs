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
    public partial class AutoCloseMessageBox : Form
    {
        public AutoCloseMessageBox(int prompt_time)
        {
            InitializeComponent();
            TimeLeftText(prompt_time);
        }

        internal void AskUser()
        {
            this.Show();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        internal void TimeLeftText(int timeleft_ms)
        {
            this.lblTimeLeft.Text = (timeleft_ms / 1000).ToString() + " seconds";
        }
    }
}
