using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplifiedDrawingModel
{
    public class DrawOvalAction : IDrawAction
    {
        private readonly Pen _pen;
        private readonly Point _center;
        private readonly Point _heightWidth;
        private readonly Brush _brush;
        private bool _flag;
        private readonly int _height;
        private readonly int _width;

        public DrawOvalAction(Pen pen, int x, int y, int x2, int y2)
        {
            _pen = pen;
            _center = new Point(x, y);
            _heightWidth = new Point(x2, y2);
            _width = Math.Abs(_heightWidth.X-_center.X);
            _height = Math.Abs(_heightWidth.Y - _center.Y);
        }
        public DrawOvalAction(Brush brush, int x, int y, int x2, int y2 ,bool flag)
        {
            _brush = brush;
            _center = new Point(x, y);
            _heightWidth = new Point(x2,y2);
            _flag = flag;
            _width = Math.Abs(_heightWidth.X - _center.X);
            _height = Math.Abs(_heightWidth.Y - _center.Y);
        }

        public void DrawOn(Graphics graphics)
        {
            if (_flag == true)
            {
                graphics.FillEllipse(_brush, _center.X, _center.Y, _width, _height);
            }
            else
            {
                graphics.DrawEllipse(_pen, _center.X, _center.Y, _width,_height);
            }
            
        }
    }
}