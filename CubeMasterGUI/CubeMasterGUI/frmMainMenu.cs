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
        private ctrlTimer FormTimer { get; set; }

        public frmMainMenu()
        {
            InitializeComponent();
            SetApplicationIcons();
            this.FormTimer = new ctrlTimer();
            FormTimer.InitializeTimers(this);
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
