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
        /// <summary>
        /// Controller for the game form
        /// </summary>
        private Games _gameController;

        /// <summary>
        /// Constructs a new game form
        /// </summary>
        /// <param name="cube">Cube controller</param>
        /// <param name="parentWidth">Parent form's width</param>
        /// <param name="parentHeight">Parent form's height</param>
        public frmGames(ref CubeController.Cube cube, int parentWidth, int parentHeight)
        {
            InitializeComponent();

            _gameController = new Games(ref cube);

            this.Width = parentWidth;
            this.Height = parentHeight;

            InvokeTimerProtocol();
        }

        /// <summary>
        /// Initializes the timers
        /// </summary>
        private void InvokeTimerProtocol()
        {
            if (!this.DesignMode)
            {
                this.tmrGames.InitializeTimers();
            }
        }
        
        /// <summary>
        /// Halts the game timer and launches a new game of snake
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSnake_Click(object sender, EventArgs e)
        {
            tmrGames.HaltTimers();
            _gameController.LaunchSnake(this.Width, this.Height);
        }

        /// <summary>
        /// Halts the game timer and launches a new catcher game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCatcher_Click(object sender, EventArgs e)
        {
            tmrGames.HaltTimers();
            _gameController.LaunchCatcher(this.Width, this.Height);
        }

        /// <summary>
        /// Resets the timer on mouse move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGames_MouseMove(object sender, MouseEventArgs e)
        {
            this.tmrGames.ResetTimers();
        }

        /// <summary>
        /// Resets the timer on mouse click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGames_MouseClick(object sender, MouseEventArgs e)
        {
            this.tmrGames.ResetTimers();
        }
    }
}
