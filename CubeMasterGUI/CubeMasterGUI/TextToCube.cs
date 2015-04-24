using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeMasterGUI
{
    public class TextToCube
    {
        private CubeController.Cube _cube;

        public enum TEXT_EFFECT { FRONT_TO_BACK, BACK_TO_FRONT, CLOCKWISE_BANNER, COUNTERCLOCKWISE_BANNER, SPIN_3D };

        public TEXT_EFFECT SelectedTextEffect { get; set; }

        public TextToCube(ref CubeController.Cube cube)
        {
            _cube = cube;
            this.SelectedTextEffect = TEXT_EFFECT.BACK_TO_FRONT;
        }
    }
}
