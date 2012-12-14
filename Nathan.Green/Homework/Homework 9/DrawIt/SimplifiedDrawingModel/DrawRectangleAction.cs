using System.Drawing;

namespace SimplifiedDrawingModel
{
    public class DrawRectangleAction : IDrawAction
    {
        private readonly Pen _pen;
        private readonly Brush _brush;
        private readonly Point _startPoint;
        private readonly int _startPointX;
        private readonly int _startPointY;
        private readonly int _width;
        private readonly int _height;
        private readonly bool _fill;

        public DrawRectangleAction(Pen pen, int x1, int y1, int width, int height)
        {
            _pen = pen;
            _startPoint = new Point(x1, y1);
            _width = width;
            _height = height;
        }

        public DrawRectangleAction(Brush brush, int x1, int y1, int width, int height, bool fill)
        {
            _brush = brush;
            _startPointX = x1;
            _startPointY = y1;
            _width = width;
            _height = height;
            _fill = fill;
        }

        public void DrawOn(Graphics graphics)
        {
            if (_fill)
            {
                graphics.FillRectangle(_brush, _startPointX, _startPointY, _width, _height);
            }
            else
            {
                graphics.DrawRectangle(_pen, _startPoint.X, _startPoint.Y, _width, _height);
            }
        }
    }
}
