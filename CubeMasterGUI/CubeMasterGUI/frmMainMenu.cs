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
        public frmMainMenu()
        {
            InitializeComponent();
            SetApplicationIcons();
            InvokeTimerProtocol();
        }

        private void SetApplicationIcons()
        {
            this.appAudioVis.SetBkgdImage(AssetHandler._audioVisURL);
            this.appFreeDraw.SetBkgdImage(AssetHandler._freeDrawURL);
            this.appGame.SetBkgdImage(AssetHandler._gamesURL);
            this.appPreset.SetBkgdImage(AssetHandler._presetURL);
            this.appText2Cube.SetBkgdImage(AssetHandler._text2CubeURL);
        }

        private void frmMainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            this.MainMenuTimer.ResetTimers();
        }

        private void InvokeTimerProtocol()
        {
            if( this.DesignMode == false )
            {
                this.MainMenuTimer.InitializeTimers();
            }
        }

        private void appFreeDraw_MouseClick(object sender, MouseEventArgs e)
        {
            frmStartScreen startScreen = (frmStartScreen)this.ParentForm;
            CubeController rootCube = startScreen.GetRootCubeController();
            frmFreeDraw freeDraw = new frmFreeDraw(ref rootCube);

            if( freeDraw.ShowDialog() == DialogResult.OK )
            {

            }
        }
    }
}
