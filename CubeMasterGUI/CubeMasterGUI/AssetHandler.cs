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
        public static string Text2CubeURL = TopLevelDir + @"\images\txt2cube.png";

        // Color Palette.
        public static System.Drawing.Color FormBackColor = System.Drawing.Color.GhostWhite;
        public static System.Drawing.Color BtnBackColor_Tertiary = System.Drawing.Color.LightBlue;
        public static System.Drawing.Color BtnBackColor_Secondary = System.Drawing.Color.SteelBlue;
        public static System.Drawing.Color BtnBackColor_Primary = System.Drawing.Color.GhostWhite;
        public static System.Drawing.Color TxtColor_Primary = System.Drawing.Color.SteelBlue;
        public static System.Drawing.Color TxtColor_Secondary = System.Drawing.Color.White;
    }
}
