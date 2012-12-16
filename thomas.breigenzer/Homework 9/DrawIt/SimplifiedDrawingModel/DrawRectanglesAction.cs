using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplifiedDrawingModel
{
    public class DrawRectangleAction : IDrawAction
    {
        private readonly Pen _pen;
        private readonly Point _startPoint;
        private readonly Point _endPoint;
        private readonly int _width;
        private readonly int _height;
        private readonly Brush _brush;
        readonly bool _fillShape;
        
        public DrawRectangleAction(Pen pen, int x1, int x2, int y1, int y2, bool fillShape)
        {
            _pen = pen;
            _brush = pen.Brush;
            _fillShape = fillShape;
            _startPoint = new Point(x1, y1);
            _endPoint = new Point(x2, y2);
            _width = Math.Abs(_startPoint.X - _endPoint.X);
            _height = Math.Abs(_startPoint.Y - _endPoint.Y);
            if (Control.ModifierKeys == Keys.Shift)
            {
                _height = _width;
            }
        }

        public void DrawOn(Graphics graphics)
        {
            if (_fillShape)
            {
                graphics.FillRectangle(_brush, Math.Min(_startPoint.X, _endPoint.X), Math.Min(_startPoint.Y, _endPoint.Y), _width, _height);
            }
                graphics.DrawRectangle(_pen, Math.Min(_startPoint.X, _endPoint.X), Math.Min(_startPoint.Y, _endPoint.Y), _width, _height);
        }
    }
} 