using System;

namespace ExploringCSharp
{
    public class DoingMath
    {
        public static int PowerOfTen = 0;

        public int ReturnTheLargerNumber(int number1, int number2)
        {
            return Math.Max(number1,number2);
        }

        public int GetBiggestMagnitude(int number1, int number2)
        {
            if (Math.Abs(number1) == (Math.Max(Math.Abs(number1), Math.Abs(number2))))
            {
                return number1;
            }
            else
                {
                    return number2;
                }
        }

        public int MultiplyByTheNextLargerPowerOfTen(int number)
        {
            return (int) (number * Math.Pow(10, PowerOfTen++));
        }
    }
}
