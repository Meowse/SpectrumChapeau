using System;
using System.Drawing;

namespace DrawIt
{
    // "static", in the declaration of a class, means "You can't make instances of this class.  It only exists
    // in order to hold some static methods."
    public static class MathHelpers
    {
        // "static", in the declaration of a method, means "You don't need to make instances of this class in order
        // to call this method.  You can just say "MathHelpers.GetRadius(...)", instead of needing to make a 
        // "MathHelpers myMathHelpers = new MathHelpers();" and then "myMathHelpers.GetRadius(...)"
        //
        // It means, roughly, "This method is not part of an instance.  It belongs to the whole class."
        public static int GetRadius(Point center, Point pointOnCircle)
        {
            return (int)Math.Round(Math.Sqrt(Math.Pow(center.X - pointOnCircle.X, 2) + Math.Pow(center.Y - pointOnCircle.Y,2)));
        }

        public static int GetHeight(Point startingPoint, Point endingPoint)
        {
            int height = (endingPoint.Y - startingPoint.Y);

            return (Math.Abs(height));
        }

        public static int GetWidth(Point startingPoint, Point endingPoint)
        {
            int width = (endingPoint.X - startingPoint.X);

            return (Math.Abs(width));
        }
    }
}
