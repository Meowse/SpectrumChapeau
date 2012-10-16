using System;
using System.Math;

namespace ExploringCSharp
{
    public class DoingMath
    {
        public int ReturnTheLargerNumber(int number1, int number2)
        {
            int x = 0;
            int y = 0;
            int result = Math.Max(x, y);

            return result;
        }

        public int GetBiggestMagnitude(int number1, int number2)
        {
            int x = 0;
            int y = 0;
            int result = Math.Max(Math.Abs(x), Math.Abs(y)); 
            
            return result;
        }

        public int MultiplyByTheNextLargerPowerOfTen(int number)
        {
            // Try googling "C# exponents and logarithms".  Or just "exponents and logarithms",
            // if college math was too long ago for you (I had to look it up the last time I needed
            // to do this, so don't feel bad if you do, too).


            return 0;
        }
    }
}
