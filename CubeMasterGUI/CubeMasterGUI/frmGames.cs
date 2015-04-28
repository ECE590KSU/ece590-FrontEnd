using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeMasterGUI
{
    public partial class frmGames : Form
    {
        private Games _gameController;

        public frmGames(ref CubeController.Cube cube, int parentWidth, int parentHeight)
        {
            InitializeComponent();

            _gameController = new Games(ref cube);

            this.Width = parentWidth;
            this.Height = parentHeight;

            InvokeTimerProtocol();
        }

        private void InvokeTimerProtocol()
        {
            if (!this.DesignMode)
            {
                this.tmrGames.InitializeTimers();
            }
        }

        private void btnSnake_Click(object sender, EventArgs e)
        {
            _gameController.LaunchSnake(this.Width, this.Height);
        }

        private void frmGames_MouseMove(object sender, MouseEventArgs e)
        {
            this.tmrGames.ResetTimers();
        }

        private void frmGames_MouseClick(object sender, MouseEventArgs e)
        {
            this.tmrGames.ResetTimers();
        }
    }
}
