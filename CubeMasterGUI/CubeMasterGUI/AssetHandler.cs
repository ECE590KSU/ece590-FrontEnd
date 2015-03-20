using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeMasterGUI
{
    public static class AssetHandler
    {
        // Images.
        private static string _topLevelDir = (Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString())).ToString();
        public static string _freeDrawURL = _topLevelDir + @"\images\freedraw.png";
        public static string _presetURL = _topLevelDir + @"\images\presets.png";
        public static string _gamesURL = _topLevelDir + @"\images\games.png";
        public static string _audioVisURL = _topLevelDir + @"\images\audiovis.png";
        public static string _text2CubeURL = _topLevelDir + @"\images\txt2cube.png";
    }
}
