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
        private static string TopLevelDir = (Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString())).ToString();
        public static string FreeDrawURL = TopLevelDir + @"\images\freedraw.png";
        public static string PresetURL = TopLevelDir + @"\images\presets.png";
        public static string GamesURL = TopLevelDir + @"\images\games.png";
        public static string AudioVisURL = TopLevelDir + @"\images\audiovis.png";
        public static string Text2CubeURL = TopLevelDir + @"\images\txt2cube.png";
    }
}
