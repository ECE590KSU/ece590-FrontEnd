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
        protected System.Windows.Forms.Timer FormTimer { get; private set; }

        public frmMainMenu()
        {
            InitializeComponent();
            SetApplicationIcons();
            InitializeFormTimer();
        }

        private void SetApplicationIcons()
        {
            this.appAudioVis.SetBkgdImage(AssetHandler.AudioVisURL);
            this.appFreeDraw.SetBkgdImage(AssetHandler.FreeDrawURL);
            this.appGame.SetBkgdImage(AssetHandler.GamesURL);
            this.appPreset.SetBkgdImage(AssetHandler.PresetURL);
            this.appText2Cube.SetBkgdImage(AssetHandler.Text2CubeURL);
        }

        private void InitializeFormTimer()
        {
            this.FormTimer = new System.Windows.Forms.Timer();
            this.FormTimer.Interval = 15000;
            this.FormTimer.Tick += new EventHandler(FormTimer_Tick);
            this.FormTimer.Start();
        }

        private void FormTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
