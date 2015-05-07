using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CubeMasterGUI
{
    public partial class frmMainMenu : Form
    {
        /// <summary>
        /// Main menu controller
        /// </summary>
        private MainMenu _mainMenuController;
        
        /// <summary>
        /// List of the application buttons
        /// </summary>
        private List<Button> _applications;

        /// <summary>
        /// Constructor for a new main menu form
        /// </summary>
        public frmMainMenu()
        {
            InitializeComponent();
            this.Height = 768;
            this.Width = 1366;
            var cube = new CubeController.Cube();
            InitializeApplications();
            InvokeTimerProtocol();

            _mainMenuController = new MainMenu(ref cube, this.Width, this.Height);
            this.ShowInTaskbar = false;
        }

        /// <summary>
        /// Initalized the appliations by adding the buttons to the list
        /// </summary>
        private void InitializeApplications()
        {
            _applications = new List<Button>();
            _applications.Add(this.btnFreeDraw);
            _applications.Add(this.btnGames);
            _applications.Add(this.btnPresets);
            _applications.Add(this.btnText2Cube);

            SetApplicationIcons();
        }

        /// <summary>
        /// Sets the button icons
        /// </summary>
        private void SetApplicationIcons()
        {
            this.btnFreeDraw.Image = SetBkgdImage(AssetHandler.FreeDrawURL);
            this.btnGames.Image = SetBkgdImage(AssetHandler.GamesURL);
            this.btnPresets.Image = SetBkgdImage(AssetHandler.PresetURL);
            this.btnText2Cube.Image = SetBkgdImage(AssetHandler.Text2CubeURL);
        }

        /// <summary>
        /// Resets timer on mouse move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            this.tmrMainMenu.ResetTimers();
        }

        /// <summary>
        /// Resets timer on mouse move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMainMenu_MouseClick(object sender, MouseEventArgs e)
        {
            this.tmrMainMenu.ResetTimers();
        }

        /// <summary>
        /// Initializes timer
        /// </summary>
        private void InvokeTimerProtocol()
        {
            if (!this.DesignMode)
            {
                this.tmrMainMenu.InitializeTimers();
            }
        }

        /// <summary>
        /// Sets a background image to a new bitpath
        /// </summary>
        /// <param name="path">Path of the image</param>
        /// <returns></returns>
        private Image SetBkgdImage(string path)
        {
            return new Bitmap(path);
        }

        /// <summary>
        /// Halts timer and launches free draw
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFreeDraw_Click(object sender, EventArgs e)
        {
            this.tmrMainMenu.HaltTimers();
            _mainMenuController.ApplicationLaunch_FreeDraw();
        }

        /// <summary>
        /// Halts timer and launches text to cube
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnText2Cube_Click(object sender, EventArgs e)
        {
            this.tmrMainMenu.HaltTimers();
            _mainMenuController.ApplicationLaunch_Text2Cube();
        }

        /// <summary>
        /// Halts timer and launches presets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPresets_Click(object sender, EventArgs e)
        {
            this.tmrMainMenu.HaltTimers();
            _mainMenuController.ApplicationLaunch_Presets();
        }

        /// <summary>
        /// Halts timer and launches games
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGames_Click(object sender, EventArgs e)
        {
            this.tmrMainMenu.HaltTimers();
            _mainMenuController.ApplicationLaunch_Games();
        }
    }
}
