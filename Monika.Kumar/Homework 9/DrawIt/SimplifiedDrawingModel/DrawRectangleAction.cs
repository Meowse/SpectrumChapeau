using System;
using System.Drawing;

namespace SimplifiedDrawingModel
{
    public class DrawRectangleAction: IDrawAction
    {
        private readonly Pen _pen;
        private readonly Brush _brush;
        private readonly Point _startpoint;
        private readonly Point _endPoint;
        private readonly int _height;
        private readonly int _width;
        private readonly bool _fillshape;

        public DrawRectangleAction(Pen pen, int x1, int y1, int x2, int y2)
        {
            _pen = pen;
            _startpoint = new Point(x1,y1);
            _endPoint = new Point(x2, y2);
            _width = Math.Abs(_startpoint.X - _endPoint.Y);
            _height = Math.Abs(_startpoint.X - _endPoint.Y);
        }
    
        
        public void DrawOn(Graphics graphics)
        {
            graphics.DrawRectangle(_pen, Math.Min(_startpoint.X, _endPoint.X), Math.Min(_startpoint.Y, _endPoint.Y), _width, _height);
        }
        
        }
    }

