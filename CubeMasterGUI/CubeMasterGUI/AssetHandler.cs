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
        #region APP_LAUNCHERS
        // Application Launcher Images.
        private static string TopLevelDir = (Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString())).ToString();
        public static string FreeDrawURL = TopLevelDir + @"\images\freedraw.png";
        public static string PresetURL = TopLevelDir + @"\images\presets.png";
        public static string GamesURL = TopLevelDir + @"\images\games.png";
        public static string Text2CubeURL = TopLevelDir + @"\images\txt2cube.png";
        #endregion

        #region BUTTON_FACES
        // FreeDraw Button Face Images.
        public static string Fill = TopLevelDir + @"\images\fill.png";
        public static string Copy = TopLevelDir + @"\images\copy.png";
        public static string Paste = TopLevelDir + @"\images\paste.png";
        public static string StartDemo = TopLevelDir + @"\images\play.png";
        public static string StopDemo = TopLevelDir + @"\images\stop.png";
        public static string DrawLine = TopLevelDir + @"\images\line.png";
        public static string DrawLineAlt = TopLevelDir + @"\images\lineAlt.png";
        public static string DrawSingle = TopLevelDir + @"\images\single.png";
        public static string DrawSingleAlt = TopLevelDir + @"\images\singleAlt.png";
        public static string DrawRect = TopLevelDir + @"\images\rect.png";
        public static string DrawRectAlt = TopLevelDir + @"\images\rectAlt.png";
        public static string DrawCircle = TopLevelDir + @"\images\circ.png";
        public static string DrawCircleAlt = TopLevelDir + @"\images\circAlt.png";
        public static string RotateCW_URL = TopLevelDir + @"\images\rotateCW.png";
        public static string RotateCCW_URL = TopLevelDir + @"\images\rotateCCW.png";
        public static string OrientXURL = TopLevelDir + @"\images\orientX.png";
        public static string OrientYURL = TopLevelDir + @"\images\orientY.png";
        public static string OrientZURL = TopLevelDir + @"\images\orientZ.png";
        #endregion

        #region COLOR_PALETTE
        // High Score File
        public static string _snakeHighScoreURL = TopLevelDir + @"\text\snakeHighScores.csv";
        public static string _catcherHighScoreURL = TopLevelDir + @"\text\catcherHighScores.csv";

        // Color Palette.
        public static System.Drawing.Color FormBackColor = System.Drawing.Color.GhostWhite;
        public static System.Drawing.Color BtnBackColor_Tertiary = System.Drawing.Color.LightBlue;
        public static System.Drawing.Color BtnBackColor_Secondary = System.Drawing.Color.SteelBlue;
        public static System.Drawing.Color BtnBackColor_Primary = System.Drawing.Color.GhostWhite;
        public static System.Drawing.Color TxtColor_Primary = System.Drawing.Color.SteelBlue;
        public static System.Drawing.Color TxtColor_Secondary = System.Drawing.Color.White;
        public static System.Drawing.Color BtnFaceDetailDarkColor = (System.Drawing.Color)System.Drawing.ColorTranslator.FromHtml("#112333");
        #endregion
    }
}
