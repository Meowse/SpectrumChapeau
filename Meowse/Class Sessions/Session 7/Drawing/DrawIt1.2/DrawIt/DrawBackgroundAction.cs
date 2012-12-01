using System.Drawing;

namespace DrawIt
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