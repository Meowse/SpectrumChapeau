using System.Drawing;

namespace SimplifiedDrawingModel
{
    public class DrawCircleAction : IDrawAction
    {
        private readonly Pen _pen;
        private readonly Brush _brush;
        private readonly int _startPointX;
        private readonly int _startPointY;
        private readonly int _width;
        private readonly int _height;
        private readonly bool _fill;

        public DrawCircleAction(Pen pen, int x, int y, int width, int height)
        {
            _pen = pen;
            _startPointX = x;
            _startPointY = y;
            _width = width;
            _height = height;
        }

        public DrawCircleAction(Brush brush, int x, int y, int width, int height, bool fill)
        {
            _brush = brush;
            _startPointX = x;
            _startPointY = y;
            _width = width;
            _height = height;
            _fill = fill;
        }

        public void DrawOn(Graphics graphics)
        {
            if (_fill)
            {
                graphics.FillEllipse(_brush, _startPointX, _startPointY, _width, _height);
            }
            else
            {
                graphics.DrawEllipse(_pen, _startPointX, _startPointY, _width, _height);
            }
        }
    }
}