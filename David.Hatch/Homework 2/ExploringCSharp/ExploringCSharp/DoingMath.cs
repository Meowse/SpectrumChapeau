using System;

namespace ExploringCSharp
{
    public class DoingMath
    {
        public int ReturnTheLargerNumber(int number1, int number2)
        {

          
          return System.Math.Max(number1, number2);

            // Type "Math.", and look at the various mathematical functions that are defined for you.
            // Notice that you'll have to say "using System.Math" at the top, or type "System.Math.",
            // in order to see it.
            // Notice also that ReSharper is *too* helpful, here, and keeps trying to turn "Math." into 
            // "DoingMath.".  Play with it until you figure out how to type "Math." without ReSharper
            // changing it into "DoingMath." on you.
            //return 0;
        }

        public int GetBiggestMagnitude(int number1, int number2)
        {
            // Try googling "C# absolute value of a number"
            if (System.Math.Abs(number1) > System.Math.Abs(number2))
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

            double newnumber;

            // Try googling "C# exponents and logarithms".  Or just "exponents and logarithms",
            // if college math was too long ago for you (I had to look it up the last time I needed
            // to do this, so don't feel bad if you do, too).
           // return Math.Pow(Math.E);

           
            //tested 

            // double newnumber = Math.Pow(Math.E,10 ); //not right

            //double newnumber = Math.Pow(number,2); // this is 9x9 = 81

            //const double source = 9;
            //const double exp = 2;
            //double newnumber = Math.Pow(source, exp); // does the same thing as above //this is 9x9 = 81

            //int newnumber = 90; // works on the first test = 90
            //return newnumber;
            
            //not a good solution below

            if (number == 1)
            {
                newnumber = number * 1;
            }
            else if (number < 11)
            {
                newnumber = number * 10;
            }
            else if (number > 10 & number < 101)
            {
                newnumber = number * 100;
            }
            else if (number > 100 & number < 1001)
            {
                newnumber = number * 1000;
            }
            else if (number > 1000 & number < 10001)
            {
                newnumber = number * 10000;
            }
            else
            {
                newnumber = 0;
            }

            int return_int = Convert.ToInt32(newnumber);


            return return_int;

      
        }
    }
}
