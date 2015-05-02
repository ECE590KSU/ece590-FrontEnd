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
        // Application Launcher Images.
        private static string TopLevelDir = (Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString())).ToString();
        public static string FreeDrawURL = TopLevelDir + @"\images\freedraw.png";
        public static string PresetURL = TopLevelDir + @"\images\presets.png";
        public static string GamesURL = TopLevelDir + @"\images\games.png";
        public static string Text2CubeURL = TopLevelDir + @"\images\txt2cube.png";

        // Button Face Images.
        public static string Copy;
        public static string Paste;
        public static string StartDemo;
        public static string StopDemo;
        public static string DrawLine;
        public static string DrawSingle;
        public static string DrawCopy;
        public static string DrawRect;
        public static string DrawCircle;
        public static string RotateCW_URL = TopLevelDir + @"\images\rotateCW.png";
        public static string RotateCCW_URL = TopLevelDir + @"\images\rotateCCW.png";

        // Color Palette.
        public static System.Drawing.Color FormBackColor = System.Drawing.Color.GhostWhite;
        public static System.Drawing.Color BtnBackColor_Tertiary = System.Drawing.Color.LightBlue;
        public static System.Drawing.Color BtnBackColor_Secondary = System.Drawing.Color.SteelBlue;
        public static System.Drawing.Color BtnBackColor_Primary = System.Drawing.Color.GhostWhite;
        public static System.Drawing.Color TxtColor_Primary = System.Drawing.Color.SteelBlue;
        public static System.Drawing.Color TxtColor_Secondary = System.Drawing.Color.White;
    }
}
