using System;
using System.Text;

namespace ExploringCSharp
{
    public class CombiningStrings
    {
        public string GreetsByCombiningStringsWithPlus(string name)
        {
            return "Hello, " + name;
        }

        public string GreetsByCombiningStringsWithFormats(string name)
        {
            // try googling "string formatting in C#"
            return String.Format("Hello, {0}", name);
        }

        public string GreetsByCombiningStringsWithStringBuilder(string name)
        {
            StringBuilder builder = new StringBuilder("Hello, ");
            // Try typing "builder." and seeing what auto-complete options ReSharper gives you.
            builder.Append(name);
            return builder.ToString();
        }
    }
}
