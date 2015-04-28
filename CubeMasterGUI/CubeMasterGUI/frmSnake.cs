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
    public partial class frmSnake : Form
    {
        private Snake _snakeController;

        public frmSnake(ref CubeController.Cube cube, int parentWidth, int parentHeight)
        {
            InitializeComponent();

            _snakeController = new Snake(ref cube);

            this.Width = parentWidth;
            this.Height = parentHeight;

            InvokeTimerProtocol();

            gameTimer.Interval = 1000 / 60; //roughly 60 fps
            gameTimer.Tick += new EventHandler(RefreshScreen);
            gameTimer.Start();

            Graphics canvas = picbxGameSpace.CreateGraphics();
            Rectangle box = new Rectangle(_snakeController.GetX(), _snakeController.GetY(), 16, 16);
            canvas.FillRectangle(Brushes.SteelBlue, new Rectangle());

        }

        private void InvokeTimerProtocol()
        {
            if (!this.DesignMode)
            {
                this.tmrSnake.InitializeTimers();
            }
        }
                
        private void frmGames_MouseMove(object sender, MouseEventArgs e)
        {
            this.tmrSnake.ResetTimers();
        }

        private void frmGames_MouseClick(object sender, MouseEventArgs e)
        {
            this.tmrSnake.ResetTimers();
        }

        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            _snakeController.ChangeInputState(e.KeyCode, true);
        }

        private void frmSnake_KeyUp(object sender, KeyEventArgs e)
        {
            _snakeController.ChangeInputState(e.KeyCode, false);
        }

        private void RefreshScreen(object sender, EventArgs e)
        {
            _snakeController.GameTickHandler();
            this.picbxGameSpace.Invalidate();
        }

        private void picbxGameSpace_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Rectangle box = new Rectangle(_snakeController.GetX(), _snakeController.GetY(), 16, 16);
            canvas.FillRectangle(Brushes.SteelBlue, new Rectangle());
        }
    }

}
