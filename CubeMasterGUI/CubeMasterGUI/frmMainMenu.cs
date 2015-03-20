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
        private frmStartScreen _startScreenParent { get; set; }

        private List<Button> _applications;

        public frmMainMenu(frmStartScreen startScreenParent)
        {
            InitializeComponent();
            InitializeApplications();
            InvokeTimerProtocol();
            _startScreenParent = startScreenParent;
        }

        private void InitializeApplications()
        {
            _applications = new List<Button>();
            _applications.Add(this.btnAudioVis);
            _applications.Add(this.btnFreeDraw);
            _applications.Add(this.btnGames);
            _applications.Add(this.btnPresets);
            _applications.Add(this.btnText2Cube);

            SetApplicationIcons();
        }

        private void SetApplicationIcons()
        {
            this.btnAudioVis.Image = SetBkgdImage(AssetHandler._audioVisURL);
            this.btnFreeDraw.Image = SetBkgdImage(AssetHandler._freeDrawURL);
            this.btnGames.Image = SetBkgdImage(AssetHandler._gamesURL);
            this.btnPresets.Image = SetBkgdImage(AssetHandler._presetURL);
            this.btnText2Cube.Image = SetBkgdImage(AssetHandler._text2CubeURL);
        }

        private void frmMainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            this.MainMenuTimer.ResetTimers();
        }

        private void InvokeTimerProtocol()
        {
            if (this.DesignMode == false)
            {
                this.MainMenuTimer.InitializeTimers();
            }
        }

        private Image SetBkgdImage(string path)
        {
            return new Bitmap(path);
        }

        private void btnFreeDraw_Click(object sender, EventArgs e)
        {
            CubeController rootCubeController = _startScreenParent.GetRootCubeController();
            frmFreeDraw freeDraw = new frmFreeDraw(ref rootCubeController);

            if (freeDraw.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
