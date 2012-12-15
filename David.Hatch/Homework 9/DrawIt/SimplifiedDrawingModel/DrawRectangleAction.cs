using System.Drawing;

namespace SimplifiedDrawingModel
{
    public class DrawRectangleAction : IDrawAction
    {
        private readonly Pen _pen;
        private readonly Point _center;
        private readonly Point _heightWidth;
        
        public DrawRectangleAction(Pen pen, int x, int y, int a, int b)
        {
            _pen = pen;
            _center = new Point(x, y);
            _heightWidth = new Point(a, b);
        }

        public void DrawOn(Graphics graphics)
        {   
            graphics.DrawRectangle(_pen, _center.X, _center.Y, _heightWidth.X - _center.X, _heightWidth.Y - _center.Y);
        }
    }
}