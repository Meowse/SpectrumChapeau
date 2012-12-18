using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplifiedDrawingModel
{
    public class DrawCircleAction : IDrawAction
    {
        private readonly Pen _pen;
        private readonly Point _center;
        private readonly int _radius;
        private readonly int _diameter;
        private readonly Brush _brush;
        private readonly bool _flag;
        private readonly float _floatStartAngle;
        private readonly float _floatArcAngle;


        public DrawCircleAction(Pen pen, int x, int y, int radius)
        {
            _pen = pen;
            _center = new Point(x, y);
            _radius = radius;
            _diameter = _radius*2;
        }

        public DrawCircleAction(Brush brush, int x, int y, int radius,bool flag)
        {
            _brush = brush;
            _center = new Point(x, y);
            _radius = radius;
            _diameter = _radius * 2;
            _flag = flag;
            _floatStartAngle = 0;
            _floatArcAngle = 360;
        }

        public void DrawOn(Graphics graphics)
        {
            if (_flag == true)
            {
                graphics.FillPie(_brush, _center.X - _radius, _center.Y - _radius, _diameter, _diameter, _floatStartAngle,
                                _floatArcAngle);
            }
            else
            {
                graphics.DrawArc(_pen, _center.X - _radius, _center.Y - _radius, _diameter, _diameter, 0, 360);
            }
            
        }
    }
}