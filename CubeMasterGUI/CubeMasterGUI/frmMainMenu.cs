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
        public int ParentScreenHeight { get; set; }
        public int ParentScreenWidth { get; set; }
        private MainMenu _mainMenuController;
        private CubeController.Cube _cube;

        private List<Button> _applications;

        public frmMainMenu()
        {
            InitializeComponent();
            _cube = new CubeController.Cube();
            ParentScreenHeight = 768;
            ParentScreenWidth = 1366;
            this.Height = ParentScreenHeight;
            this.Width = ParentScreenWidth;
            InitializeApplications();
            InvokeTimerProtocol();
            
            this.Height = ParentScreenHeight;
            this.Width = ParentScreenWidth;

            _mainMenuController = new MainMenu(ref _cube, ParentScreenWidth, ParentScreenHeight);
            this.ShowInTaskbar = false;
        }

        private void InitializeApplications()
        {
            _applications = new List<Button>();
            _applications.Add(this.btnFreeDraw);
            _applications.Add(this.btnGames);
            _applications.Add(this.btnPresets);
            _applications.Add(this.btnText2Cube);

            SetApplicationIcons();
        }

        private void SetApplicationIcons()
        {
            this.btnFreeDraw.Image = SetBkgdImage(AssetHandler.FreeDrawURL);
            this.btnGames.Image = SetBkgdImage(AssetHandler.GamesURL);
            this.btnPresets.Image = SetBkgdImage(AssetHandler.PresetURL);
            this.btnText2Cube.Image = SetBkgdImage(AssetHandler.Text2CubeURL);
        }

        private void frmMainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            this.tmrMainMenu.ResetTimers();
        }

        private void frmMainMenu_MouseClick(object sender, MouseEventArgs e)
        {
            this.tmrMainMenu.ResetTimers();
        }

        private void InvokeTimerProtocol()
        {
            if (!this.DesignMode)
            {
                this.tmrMainMenu.InitializeTimers();
            }
        }

        private Image SetBkgdImage(string path)
        {
            return new Bitmap(path);
        }

        private void btnFreeDraw_Click(object sender, EventArgs e)
        {
            this.tmrMainMenu.HaltTimers();
            _mainMenuController.ApplicationLaunch_FreeDraw();
        }

        private void btnText2Cube_Click(object sender, EventArgs e)
        {
            this.tmrMainMenu.HaltTimers();
            _mainMenuController.ApplicationLaunch_Text2Cube();
        }

        private void btnPresets_Click(object sender, EventArgs e)
        {
            this.tmrMainMenu.HaltTimers();
            _mainMenuController.ApplicationLaunch_Presets();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            this.tmrMainMenu.HaltTimers();
            _mainMenuController.ApplicationLaunch_Games();
        }
    }
}
