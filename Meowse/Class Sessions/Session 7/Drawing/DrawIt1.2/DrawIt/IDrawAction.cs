using System.Drawing;

namespace DrawIt
{
    public interface IDrawAction
    {
        void DrawOn(Graphics graphics);
    }
}