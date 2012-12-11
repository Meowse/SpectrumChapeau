using System.Drawing;

namespace SimplifiedDrawingModel
{
    public class DrawBackgroundAction : IDrawAction
    {
        private readonly Color _backgroundColor;

        public DrawBackgroundAction(Color backgroundColor)
        {
            _backgroundColor = backgroundColor;
        }

        public void DrawOn(Graphics graphics)
        {
            graphics.Clear(_backgroundColor);
        }
    }
}