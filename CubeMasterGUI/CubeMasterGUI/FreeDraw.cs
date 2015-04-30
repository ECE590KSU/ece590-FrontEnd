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

        public void SwapVoxel(int grid_x, int grid_y)
        {
            switch (this.SelectedAxis)
            {
                case CubeController.Cube.AXIS.AXIS_X:
                    _cube.SwapVoxel(this.SelectedPlane, grid_x, grid_y);
                    break;
                case CubeController.Cube.AXIS.AXIS_Y:
                    _cube.SwapVoxel(grid_x, this.SelectedPlane, grid_y);
                    break;
                case CubeController.Cube.AXIS.AXIS_Z:
                    _cube.SwapVoxel(grid_x, grid_y, this.SelectedPlane);
                    break;
                default:
                    break;
            }
        }


        public void ClearPlane(int plane)
        {
            _cube.ClearPlane(SelectedAxis, plane);
        }

        public bool[][] GetPlane(int plane)
        {
            return _cube.GetPlane(SelectedAxis, plane);
        }

        public void SetPlane(int plane)
        {
            _cube.SetPlane(SelectedAxis, plane);
        }

        public void ClearEntireCube()
        {
            _cube.ClearEntireCube();
        }

        public void Demo()
        {
            int i = 200;
            while (--i >= 0)
            {
                _cube.BoxWoopWoop(1, 200, true);
                _cube.BoxWoopWoop(1, 200, false);
            }
        }

        public void DrawLine(CubeController.Point p1, CubeController.Point p2)
        {
            _cube.DrawLine(p1, p2);
        }

        public CubeController.Point VoxelToPoint(Voxel vox)
        {
            CubeController.Point point; 

            switch (this.SelectedAxis)
            {
                case CubeController.Cube.AXIS.AXIS_X:
                    point = new CubeController.Point(this.SelectedPlane, vox.X, vox.Y);
                    break;
                case CubeController.Cube.AXIS.AXIS_Y:
                    point = new CubeController.Point(vox.X, this.SelectedPlane, vox.Y);
                    break;
                case CubeController.Cube.AXIS.AXIS_Z:
                    point = new CubeController.Point(vox.X, vox.Y, this.SelectedPlane);
                    break;
                default:
                    point = null;
                    break;
            }

            return point;
        }

        public void DrawRectangle(CubeController.Point p1, CubeController.Point p2)
        {
            _cube.DrawRectangle(this.SelectedAxis, p1, p2);
        }
    }
}
