using System;

namespace ExploringCSharp
{
    public class DoingMath
    {
        public int ReturnTheLargerNumber(int number1, int number2)
        {
           int result = Math.Max(number1, number2);
           return result;
        }

        public int GetBiggestMagnitude(int number1, int number2)
        {
            int result = Math.Max(Math.Abs(number1), Math.Abs(number2)); 
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
