using System.Drawing;

namespace SimplifiedDrawingModel
{
    public class DrawLineAction : IDrawAction
    {
        private readonly Pen _pen;

        private readonly Point _startPoint;
        private readonly Point _endPoint;
        private readonly Color _instance_pen_color;

        public DrawLineAction(Pen pen, int x1, int y1, int x2, int y2)
        {
            _pen = pen;
            _instance_pen_color = pen.Color;

            _startPoint = new Point(x1, y1);
            _endPoint = new Point(x2, y2);
        }

        public void DrawOn(Graphics graphics)
        {
            _pen.Color = _instance_pen_color;
            graphics.DrawLine(_pen, _startPoint, _endPoint);
        }
    }
}