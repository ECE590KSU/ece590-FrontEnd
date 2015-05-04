using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeMasterGUI
{
    public class Presets
    {
        private CubeController.Cube _cube;
        private List<System.Windows.Forms.Button> _presets;

        public Presets(ref CubeController.Cube cube)
        {
            _cube = cube;
            _presets = new List<System.Windows.Forms.Button>();
        }
    }
}
