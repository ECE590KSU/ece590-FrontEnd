using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeMasterGUI
{
    public class MainMenu
    {
        /// <summary>
        /// Cube controller
        /// </summary>
        private CubeController.Cube _cube;

        /// <summary>
        /// Parent screen width
        /// </summary>
        private int _parentScreenWidth;

        /// <summary>
        /// Parent screen height
        /// </summary>
        private int _parentScreenHeight;
        
        /// <summary>
        /// Constructor for the main menu controller
        /// </summary>
        /// <param name="cube">Cube controller</param>
        /// <param name="width">Parent form's width</param>
        /// <param name="height">Parent form's height</param>
        public MainMenu(ref CubeController.Cube cube, int width, int height)
        {
            _cube = cube;
            _parentScreenWidth = width;
            _parentScreenHeight = height;
        }

        /// <summary>
        /// Launches TextToCube application
        /// </summary>
        internal void ApplicationLaunch_Text2Cube()
        {
            frmTextToCube text2Cube = new frmTextToCube(ref _cube, _parentScreenWidth, _parentScreenHeight);

            if (text2Cube.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
            
            }
        }

        /// <summary>
        /// Launches FreeDraw application
        /// </summary>
        internal void ApplicationLaunch_FreeDraw()
        {
            frmFreeDraw freeDraw = new frmFreeDraw(ref _cube, _parentScreenWidth, _parentScreenHeight);

            if (freeDraw.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        /// <summary>
        /// Launches Games application
        /// </summary>
        internal void ApplicationLaunch_Games()
        {
            frmGames games = new frmGames(ref _cube, _parentScreenWidth, _parentScreenHeight);

            if (games.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        /// <summary>
        /// Launches Presets application
        /// </summary>
        internal void ApplicationLaunch_Presets()
        {
            frmPresets presets = new frmPresets(ref _cube, _parentScreenWidth, _parentScreenHeight);

            if (presets.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }
    }
}
