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
            return true;
        }

        public bool NegatesItsInputSingleLine(bool input)
        {
            // Use resharper on the above to reduce it to a single line.
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
                return false;
            }
            {
                return false;
            }
        }

        public bool TrueIfBothInputsAreTrueSingleLine(bool input1, bool input2)
        {
            // Use resharper on the above to reduce it to a single line.
            return input1 && input2;
        }

        public bool TrueIfEitherInputIsTrue(bool input1, bool input2)
        {
            if (input1)
            {
                if (input2)
                {
                    return true;
                }
                return true;
            }
            if (input2)
            {
                return true;
            }
            return false;
        }

        public bool TrueIfEitherInputIsTrueSingleLine(bool input1, bool input2)
        {
            // Use resharper on the above to reduce it to a single line.
            return input1 || input2;
        }

        public bool MustPayExtraSurchargeToRentACar(string gender, int age)
        {
            // Implement this one from scratch so that all tests pass.  
            // Age is a whole number.  The intended values and meanings of the string "gender"
            // can be inferred from the tests.
            //return false;
            switch (gender)
            {
                case "M":
                    if (age < 25)
                    {
                        return true;
                    }
                    {
                        return false;
                    }
                case "F":
                    return false;
                case "O":
                    return true;
                case "P":
                    return true;
                default:
                    return true;
            }
        }
    }
}
