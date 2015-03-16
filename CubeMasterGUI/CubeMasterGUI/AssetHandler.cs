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
        private static string TopLevelDir = (Directory.GetParent(Directory.GetCurrentDirectory())).ToString();
        public static string FreeDrawURL = TopLevelDir + @"\images\freedraw.png";
    }
}
