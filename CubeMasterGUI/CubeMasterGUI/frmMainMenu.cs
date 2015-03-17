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
        private System.Windows.Forms.Timer InactiveTimer { get; set; }
        private System.Windows.Forms.Timer PromptTimer { get; set; }

        public frmMainMenu()
        {
            InitializeComponent();
            SetApplicationIcons();
            InitializeTimers();
        }

        private void InitializeTimers()
        {
            InactiveTimer = new System.Windows.Forms.Timer();
            PromptTimer = new System.Windows.Forms.Timer();

            InactiveTimer.Interval = AssetHandler.InactiveTimeOut;
            PromptTimer.Interval = AssetHandler.PromptTimeOut;

            InactiveTimer.Tick += InactiveTimer_Tick;
            PromptTimer.Tick += PromptTimer_Tick;

            InactiveTimer.Start();
        }

        private void InactiveTimer_Tick(object sender, EventArgs e)
        {
            InactiveTimer.Stop();
            this.PromptIfDone();
        }

        private void PromptTimer_Tick(object sender, EventArgs e)
        {
            PromptTimer.Stop();
            this.Close();
        }

        private void PromptIfDone()
        {
            PromptTimer.Start();
        }

        private void SetApplicationIcons()
        {
            this.appAudioVis.SetBkgdImage(AssetHandler.AudioVisURL);
            this.appFreeDraw.SetBkgdImage(AssetHandler.FreeDrawURL);
            this.appGame.SetBkgdImage(AssetHandler.GamesURL);
            this.appPreset.SetBkgdImage(AssetHandler.PresetURL);
            this.appText2Cube.SetBkgdImage(AssetHandler.Text2CubeURL);
        }
    }
}
