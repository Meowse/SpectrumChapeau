
// Bryna Shane
// .Net Development Foundations, Fall 2012
// Homework Assignment #2
// October 17, 2012
//
// DoingMath.cs
//
// Tasks:  Make all the tests work.
// Extra Credit:  Make the extra credit tests work.


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

            return result == Math.Abs(number1) ? number1 :number2;
        }

        public int MultiplyByTheNextLargerPowerOfTen(int number)
        {
            const double DTEN = 10.0;
            double finalValue = 0.0;
            string x = number.ToString();
            int isDivisibleByTen = number%10;

            int length = x.Length;

            if (number == 1 || number == 0)
                {
                    finalValue = number * Math.Pow(DTEN, 0);  //Not simpler here because I wanted to use Math.Pow.
                }
            else if (isDivisibleByTen == 0)
                {
                    finalValue = number * Math.Pow(DTEN, length - 1);
                }
                 else
                 {
                     finalValue = number * Math.Pow(DTEN, length);
                 }
            int result = Convert.ToInt32(finalValue);
            return result;
        }
    }
}
