using System;
using System.Drawing;

namespace SimplifiedDrawingModel
{
    public class DrawRectangleAction : IDrawAction
    {
        private readonly Pen _pen;
        private readonly Point _startPoint;
        private readonly int _width;
        private readonly int _height;

        public DrawRectangleAction(Pen pen, int x1, int y1, int width, int height)
        {
            _pen = pen;
            _startPoint = new Point(x1, y1);
            _width = width;
            _height = height;
        }

        public void DrawOn(Graphics graphics)
        {
            graphics.DrawRectangle(_pen, _startPoint.X, _startPoint.Y, _width, _height);
        }
    }
}
