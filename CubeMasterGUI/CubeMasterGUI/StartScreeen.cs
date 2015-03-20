using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CubeMasterGUI
{
    public class StartScreeen
    {
        private CubeController _rootCubeController;

        public StartScreeen()
        {
            _rootCubeController = new CubeController();
        }

        public CubeController GetRootCubeController()
        {
            return _rootCubeController;
        }
    }
}
