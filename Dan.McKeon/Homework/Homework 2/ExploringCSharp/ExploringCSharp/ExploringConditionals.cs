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
            // Use ReSharper on the code above to make it a single line.
            // You may want to google "C# the question mark colon operator".
            // My first thought was to google "C# ?:", but it turns out that
            // google doesn't handle pure punctuation that well.
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
            // Use Resharper on the code above to eliminate the "else" case.  This is a common pattern
            // when you want to do something simple to handle invalid input (like a null string),
            // and have something more complicated to do with normal input.  You just check for
            // the invalid input, and return if you find it.  The rest of the method can be as 
            // complicated as you want, and it doesn't need to be "nested" inside an "else" clause.
            if (stringToDouble == null)
            {
                return null;
            }
            return stringToDouble + stringToDouble;
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
            // use Resharper on the first ComplexCondition to convert the entire thing
            // to a switch statement.
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
            }
            return "Too rich for my blood!";
        }
    }
}
