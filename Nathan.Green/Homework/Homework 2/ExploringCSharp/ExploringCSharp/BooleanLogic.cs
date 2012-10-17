namespace ExploringCSharp
{
    public class BooleanLogic
    {
        public bool NegatesItsInput(bool input)
        {
            if (input)
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
            if (input1)
            {
                if (input2)
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
                return false;
            }
        }

        public bool TrueIfBothInputsAreTrueSingleLine(bool input1, bool input2)
        {
            return input1 && input2;
        }

        public bool TrueIfEitherInputIsTrue(bool input1, bool input2)
        {
            if (input1)
            {
                return true;
            }
            else
            {
                if (input2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool TrueIfEitherInputIsTrueSingleLine(bool input1, bool input2)
        {
            return input1 || input2;
        }

        public bool MustPayExtraSurchargeToRentACar(string gender, int age)
        {
            // Implement this one from scratch so that all tests pass.  
            // Age is a whole number.  The intended values and meanings of the string "gender"
            // can be inferred from the tests.

            switch (gender)
            {
                case "M":
                    if (age < 25)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "F":
                    return false;
                case "O":
                    return true;
                default:
                    return true;
            }
        }
    }
}
