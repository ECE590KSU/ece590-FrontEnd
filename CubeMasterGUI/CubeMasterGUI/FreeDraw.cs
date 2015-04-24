using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CubeMasterGUI
{
    public class FreeDraw
    {
        private CubeController.Cube _cube;
        public CubeController.Cube.AXIS SelectedAxis { get; set; }
        
        // Replace function calls using 'int plane' with 'SelectedPlane'. 
        public int SelectedPlane { get; set; }

        public enum DRAWING_MODE { SINGLE, LINE, RECTANGLE, CIRCLE };
        public DRAWING_MODE CurrentDrawingMode { get; set; }

        public FreeDraw(ref CubeController.Cube cube)
        {
            _cube = cube;
            this.CurrentDrawingMode = DRAWING_MODE.SINGLE;
        }

        public void SwapVoxel(int x, int y, int z)
        {
            _cube.SwapVoxel(x,y,z);
        }

        public void ClearPlane(int plane)
        {
            _cube.ClearPlane(SelectedAxis, plane);
            _cube.RenderCube();
        }

        public bool[][] GetPlane(int plane)
        {
            return _cube.GetPlane(SelectedAxis, plane);
        }

        public void SetPlane(int plane)
        {
            _cube.SetPlane(SelectedAxis, plane);
        }
    }
}
