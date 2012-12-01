using System.Drawing;

namespace SimplifiedDrawingModel
{
    public interface IDrawAction
    {
        void DrawOn(Graphics graphics);
    }
}