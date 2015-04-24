using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeMasterGUI
{
    public partial class DrawingFunction : UserControl
    {
        public FreeDraw _freeDrawController;
        private FreeDraw.DRAWING_MODE _drawingMode;

        public DrawingFunction()
        {
            InitializeComponent();
        }

        public void SetText(string text)
        {
            this.btnFunction.Text = text;
        }

        public void SetImage(Image img)
        {
            this.btnFunction.Image = img as Bitmap;
        }

        public void SetDrawingMode(FreeDraw.DRAWING_MODE drawMode)
        {
            _drawingMode = drawMode;
        }

        public void SetImage(string path)
        {
            this.btnFunction.Image = new Bitmap(path);
        }

        public void SetController(ref FreeDraw freeDrawController)
        {
            _freeDrawController = freeDrawController;
        }

        private void DrawingFunction_Click(object sender, EventArgs e)
        {
            _freeDrawController.CurrentDrawingMode = _drawingMode;
        }
    }
}
