using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplifiedDrawingModel
{
   public class DrawXesAction: IDrawAction
   {
       private readonly Pen _pen ;
       private readonly Point _startPoint1;
       private readonly Point _endPoint1;
       private readonly Point _startPoint2;
       private readonly Point _endPoint2;

       public DrawXesAction(Pen pen, int x1, int x2, int y1, int y2)
       {
           _pen = pen;
           _startPoint1 = new Point(x1, y1);
           _endPoint1 = new Point(x2, y2);
           _startPoint2 = new Point(x2, y1);
           _endPoint2 = new Point(x1, y2);
        }

       public void DrawOn(Graphics graphics)
       {
           graphics.DrawLine(_pen, _startPoint1, _endPoint1);
           graphics.DrawLine(_pen, _startPoint2, _endPoint2);
         }

   }
}
