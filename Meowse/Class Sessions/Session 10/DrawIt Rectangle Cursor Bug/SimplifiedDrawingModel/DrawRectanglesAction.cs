using System;
using System.Drawing;

namespace SimplifiedDrawingModel
{
    public class DrawRectangleAction : IDrawAction
    {
        private readonly Pen _pen;
        private readonly Point _startPoint;
        private readonly Point _endPoint;
        private readonly int _width;
        private readonly int _height;
        
        public DrawRectangleAction(Pen pen, int x1, int x2, int y1, int y2)
        {
            _pen = pen;
            _startPoint = new Point(x1, y1);
            _endPoint = new Point(x2, y2);
            //_width = new int();
            //_height = new int();
            _width = (int)System.Math.Sqrt(System.Math.Pow(_startPoint.X - _endPoint.X, 2));
            _height = (int) System.Math.Sqrt(System.Math.Pow(_startPoint.Y - _endPoint.Y, 2));
        }

        public void DrawOn(Graphics graphics)
        {
            graphics.DrawRectangle(_pen, Math.Min(_startPoint.X, _endPoint.X), Math.Min(_startPoint.Y, _endPoint.Y), _width, _height);
        }
    }
}