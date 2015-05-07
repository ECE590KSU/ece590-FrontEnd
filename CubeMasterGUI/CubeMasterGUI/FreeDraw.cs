using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CubeMasterGUI
{
    public class FreeDraw
    {
        private CubeController.Cube _cube;
        
        private bool[][] _planeBuffer;

        private Dictionary<String, CubeController.Cube.REFLECTION> _reflections;
        private Dictionary<Button, Tuple<Bitmap, Bitmap>> _drawingButtonImages;

        public CubeController.Cube.AXIS SelectedAxis { get; set; }
        public CubeController.Cube.REFLECTION Reflection { get; set; }
        public CubeController.Cube.DIRECTION Direction { get; set; }

        // Replace function calls using 'int plane' with 'SelectedPlane'. 
        public int SelectedPlane { get; set; }

        public enum DRAWING_MODE { SINGLE, LINE, RECTANGLE, CIRCLE };
        public DRAWING_MODE CurrentDrawingMode { get; set; }

        public FreeDraw(ref CubeController.Cube cube)
        {
            _cube = cube;
            this.CurrentDrawingMode = DRAWING_MODE.SINGLE;
            this.Reflection = CubeController.Cube.REFLECTION.ORIGIN;

            _drawingButtonImages = new Dictionary<Button, Tuple<Bitmap, Bitmap>>();

            _reflections = new Dictionary<string, CubeController.Cube.REFLECTION>();
            _reflections.Add("origin", CubeController.Cube.REFLECTION.ORIGIN);
            _reflections.Add("terminus", CubeController.Cube.REFLECTION.TERMINUS);
        }

        public void SetReflection(string refl)
        {
            this.Reflection = _reflections[refl.ToLowerInvariant()];
        }

        public void SetVoxel(int grid_x, int grid_y)
        {
            switch (this.SelectedAxis)
            {
                case CubeController.Cube.AXIS.AXIS_X:
                    _cube.SetVoxel(this.SelectedPlane, grid_x, grid_y);
                    break;
                case CubeController.Cube.AXIS.AXIS_Y:
                    _cube.SetVoxel(grid_x, this.SelectedPlane, grid_y);
                    break;
                case CubeController.Cube.AXIS.AXIS_Z:
                    _cube.SetVoxel(grid_y, grid_x, this.SelectedPlane);
                    break;
                default:
                    break;
            }
        }

        public void SetVoxel(int x, int y, int z)
        {
            _cube.SetVoxel(x, y, z);
        }

        public void SetVoxel(CubeController.Point p)
        {
            _cube.SetVoxel(p.X, p.Y, p.Z);
        }

        public void ClearVoxel(int grid_x, int grid_y)
        {
            switch (this.SelectedAxis)
            {
                case CubeController.Cube.AXIS.AXIS_X:
                    _cube.ClearVoxel(this.SelectedPlane, grid_x, grid_y);
                    break;
                case CubeController.Cube.AXIS.AXIS_Y:
                    _cube.ClearVoxel(grid_x, this.SelectedPlane, grid_y);
                    break;
                case CubeController.Cube.AXIS.AXIS_Z:
                    _cube.ClearVoxel(grid_y, grid_x, this.SelectedPlane);
                    break;
                default:
                    break;
            }
        }

        public void ClearVoxel(int x, int y, int z)
        {
            _cube.ClearVoxel(x, y, z);
        }

        public void ClearVoxel(CubeController.Point p)
        {
            _cube.ClearVoxel(p.X, p.Y, p.Z);
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
                    _cube.SwapVoxel(grid_y, grid_x, this.SelectedPlane);
                    break;
                default:
                    break;
            }
        }

        public void SwapVoxel(int x, int y, int z)
        {
            _cube.SwapVoxel(x, y, z);
        }

        public void SwapVoxel(CubeController.Point p)
        {
            _cube.SwapVoxel(p.X, p.Y, p.Z);
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
                _cube.BoxWoopWoop(1, 200, true, 8);
                _cube.BoxWoopWoop(1, 200, false, 8);
            }
        }

        public void DrawLine(CubeController.Point p1, CubeController.Point p2)
        {
            _cube.DrawLine(p1, p2);
        }

        public void DrawRectangle(CubeController.Point p1, CubeController.Point p2)
        {
            _cube.DrawRectangle(this.SelectedAxis, p1, p2);
        }

        public void DrawCircle(CubeController.Point center, CubeController.Point rad)
        {
            _cube.DrawCircle(this.SelectedAxis, center, rad);
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
                    point = new CubeController.Point(vox.Y, vox.X, this.SelectedPlane);
                    break;
                default:
                    point = null;
                    break;
            }

            return point;
        }

        public void Rotate(int theta)
        {
            _cube.RotatePlane(this.SelectedAxis, this.SelectedPlane, theta);
        }

        /// <summary>
        /// Allows a user to copy their selected plane and axis 
        /// to a plane buffer (later used for Pasting).
        /// </summary>
        public void CopyPlane()
        {
            _planeBuffer = _cube.GetPlane(this.SelectedAxis, this.SelectedPlane);
        }
        
        /// <summary>
        /// Allows a user to paste a previously copied plane from a plane buffer to 
        /// the desired cube plane and axis. 
        /// </summary>
        public void PastePlane()
        {
            if (_planeBuffer != null)
            {
                _cube.PatternSetPlane(this.SelectedAxis, this.SelectedPlane, _planeBuffer);
            }
        }

        public void SymmetryX()
        {
            _cube.SymmetryAlongAxis(CubeController.Cube.AXIS.AXIS_X, this.Reflection);
        }

        public void SymmetryY()
        {
            _cube.SymmetryAlongAxis(CubeController.Cube.AXIS.AXIS_Y, this.Reflection);
        }

        public void SymmetryZ()
        {
            _cube.SymmetryAlongAxis(CubeController.Cube.AXIS.AXIS_Z, this.Reflection);
        }

        public void ShiftUp()
        {
            this.Direction = CubeController.Cube.DIRECTION.FORWARD;
            _cube.ShiftAndRoll(this.SelectedAxis, this.Direction);
        }

        public void ShiftDown()
        {
            this.Direction = CubeController.Cube.DIRECTION.REVERSE;
            _cube.ShiftAndRoll(this.SelectedAxis, this.Direction);
        }

        /// <summary>
        /// Returns the appropriate image for a button. 
        /// </summary>
        /// <param name="btn">The button to lookup images for.</param>
        /// <param name="alt">Do we need the alternate image?</param>
        /// <returns>Bitmap representing the appropriate image.</returns>
        public Bitmap GetDrawingFunctionImg(Button btn, bool alt)
        {
            return alt ? _drawingButtonImages[btn].Item2 : _drawingButtonImages[btn].Item1;
        }

        public void SwapDrawingFunctionImg(Button toSwap, bool alt)
        {
            toSwap.Image = alt ? _drawingButtonImages[toSwap].Item2 : _drawingButtonImages[toSwap].Item1;
        }

        public void AddDrawingImagesEntry(Button btn, string path1, string path2)
        {
            _drawingButtonImages.Add(btn, new Tuple<Bitmap, Bitmap>(new Bitmap(path1), new Bitmap(path2)));
        }
    }
}
