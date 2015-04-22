using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CubeMasterGUI
{
    public class FreeDraw
    {
        private CubeController.Cube _cubeController;
        public CubeController.Cube.AXIS SelectedAxis { get; set; }

        public FreeDraw(ref CubeController.Cube cube)
        {
            _cubeController = cube;
        }
    }
}
