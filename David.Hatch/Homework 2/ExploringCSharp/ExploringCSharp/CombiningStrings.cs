using System.Text;

//homework 2 final was checked in as base line

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
           return string.Format("Hello, {0}", name);
        }

        public string GreetsByCombiningStringsWithStringBuilder(string name)
        {
            StringBuilder builder = new StringBuilder(100);
            // Try typing "builder." and seeing what auto-complete options ReSharper gives you.
            builder.Append("Hello, ");
            builder.Append(name);
            
            return builder.ToString();
        }
    }
}
