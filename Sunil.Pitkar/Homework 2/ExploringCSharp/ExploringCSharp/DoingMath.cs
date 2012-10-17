using System;

namespace ExploringCSharp
{
    public class DoingMath
    {
        public int ReturnTheLargerNumber(int number1, int number2)
        {
            // Type "Math.", and look at the various mathematical functions that are defined for you.
            // Notice that you'll have to say "using System.Math" at the top, or type "System.Math.",
            // in order to see it.
            // Notice also that ReSharper is *too* helpful, here, and keeps trying to turn "Math." into 
            // "DoingMath.".  Play with it until you figure out how to type "Math." without ReSharper
            // changing it into "DoingMath." on you.
          return System.Math.Max(number1, number2);
        }

        public int GetBiggestMagnitude(int number1, int number2)
        {
            // Try googling "C# absolute value of a number"
            //return 0;
            //return System.Math.Max(System.Math.Abs(number1),System.Math.Abs(number2));
            //return System.Math.Max(number1,number2);
            if(System.Math.Abs(number1) > System.Math.Abs(number2))
           {
                return number1;
            }
            return number2;
        }

        public int MultiplyByTheNextLargerPowerOfTen(int number)
        {
            // Try googling "C# exponents and logarithms".  Or just "exponents and logarithms",
            // if college math was too long ago for you (I had to look it up the last time I needed
            // to do this, so don't feel bad if you do, too).
         
            int newNumber = number;
            double exponent = Math.Log10(number);
            double newExponent = exponent;
            
            int remainder;
            int quotient = Math.DivRem(number, 10, out remainder);
            
            if (remainder == 0)
            {
                newExponent = exponent + exponent;
                newNumber = (int)Math.Pow(10, newExponent);
            }
            else
            {
                newExponent = Math.Ceiling(exponent);
                newNumber = number * (int)Math.Pow(10, newExponent);
            }
        return newNumber;
        }
    }
}
