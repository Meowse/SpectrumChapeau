using System.Drawing;

namespace SimplifiedDrawingModel
{
    public class DrawLineAction : IDrawAction
    {
        private readonly Pen _pen;
        private readonly Point _startPoint;
        private readonly Point _endPoint;

        public DrawLineAction(Pen pen, int x1, int y1, int x2, int y2)
        {
            _pen = pen;
            _startPoint = new Point(x1, y1);
            _endPoint = new Point(x2, y2);
        }

        public void DrawOn(Graphics graphics)
        {
            graphics.DrawLine(_pen, _startPoint, _endPoint);
        }

    }
}