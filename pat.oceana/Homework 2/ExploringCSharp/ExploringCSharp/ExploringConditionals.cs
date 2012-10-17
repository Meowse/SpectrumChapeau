namespace ExploringCSharp
{
    public class ExploringConditionals
    {
        public string ConvertsBoolToYesOrNo(bool value)
        {
            if (value)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        public string ConvertsBoolToYesOrNoSingleLine(bool value)
        {
            return value ? "Yes" : "No";
        }

        public string DoubleString(string stringToDouble)
        {
            if (stringToDouble == null)
            {
                return null;
            }
            else
            {
                return stringToDouble + stringToDouble;
            }            
        }

        public string DoubleStringWithInputValidationPattern(string stringToDouble)
        {
            return stringToDouble == null ? null : stringToDouble + stringToDouble;
        }

        public string ComplexConditionUsingElseIf(int value)
        {
            if (value == 0)
            {
                return "Free!";
            }
            else if (value == 1)
            {
                return "Cheap as dirt!";
            }
            else if (value == 2)
            {
                return "Twice as expensive as dirt...";
            }
            else if (value == 3)
            {
                return "TANSTAAFL: There ain't no such thing as a free lunch.";
            }
            else
            {
                return "Too rich for my blood!";
            }
        }

        public string ComplexConditionUsingReturnsAndIfs(int value)
        {
            // Use Resharper on the above to get rid of all of the "else" clauses
            if (value == 0)
            {
                return "Free!";
            }
            if (value == 1)
            {
                return "Cheap as dirt!";
            }
            if (value == 2)
            {
                return "Twice as expensive as dirt...";
            }
            if (value == 3)
            {
                return "TANSTAAFL: There ain't no such thing as a free lunch.";
            }
            return "Too rich for my blood!";
        }

        public string ComplexConditionUsingSwitch(int value)
        {
            switch (value)
            {
                case 0:
                    return "Free!";
                case 1:
                    return "Cheap as dirt!";
                case 2:
                    return "Twice as expensive as dirt...";
                case 3:
                    return "TANSTAAFL: There ain't no such thing as a free lunch.";
                default:
                    return "Too rich for my blood!";
            }

        }
    }
}
