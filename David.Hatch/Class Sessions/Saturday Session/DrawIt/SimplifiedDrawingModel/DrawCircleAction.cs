using System.Drawing;

namespace SimplifiedDrawingModel
{
    public class DrawCircleAction : IDrawAction
    {
        private readonly Pen _pen;
        private readonly Color _instance_pen_color;
        private readonly Point _center;
        private readonly int _radius;
        private readonly int _diameter;

        public DrawCircleAction(Pen pen, int x, int y, int radius)
        {
            _pen = pen;
            _instance_pen_color = pen.Color;
            _center = new Point(x, y);
            _radius = radius;
            _diameter = _radius*2;
        }

        public void DrawOn(Graphics graphics)
        {
            _pen.Color = _instance_pen_color;
            graphics.DrawArc(_pen, _center.X - _radius, _center.Y - _radius, _diameter, _diameter, 0, 360);
        }
    }
}