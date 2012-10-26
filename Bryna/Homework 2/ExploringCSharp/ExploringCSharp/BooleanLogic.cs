
// Bryna Shane
// .Net Development Foundations, Fall 2012
// Homework Assignment #2
// October 17, 2012
//
// BooleanLogic.cs
//
// Tasks:  Make all the tests work.
// Extra Credit:  Make the extra credit tests work.


namespace ExploringCSharp
{
    public class BooleanLogic
    {
       public bool NegatesItsInput(bool input)
        {
            if (input == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       public bool NegatesItsInputSingleLine(bool input)
       {
           return !input;
       }

        public bool TrueIfBothInputsAreTrue(bool input1, bool input2)
        {
            if (input1 == true)
            {
                if (input2 == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (input1 == true)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool TrueIfBothInputsAreTrueSingleLine(bool input1, bool input2)
        {
            // Use resharper on the above to reduce it to a single line.
            return (input1 && input2);
        }

        public bool TrueIfEitherInputIsTrue(bool input1, bool input2)
        {
            if (input1 == true)
            {
                if (input2)
                    return true;
                return true;
            }
            else
            {
                if (input2 == true)
                {
                    return true;
                }
                return false;
            }
        }

        public bool TrueIfEitherInputIsTrueSingleLine(bool input1, bool input2)
        {
            // Use resharper on this to reduce it to a single line.
            return (input1 || input2);
        }

        public bool MustPayExtraSurchargeToRentACar(string gender, int age)
        {
            // Implement this one from scratch so that all tests pass.  
            // Age is a whole number.  The intended values and meanings of the string "gender"
            // can be inferred from the tests.

            string g  = gender;
            int a = age;
            bool result;

            switch (g)
            {
	            case ("F"):
                    return false;
                case ("M"):
                   result = (a < 25);
                   return result;    
		        default:
                    return true;
            }
        }
    }
}
