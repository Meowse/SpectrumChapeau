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
            return string.Format("Hello, {0}", name);
        }

        public string GreetsByCombiningStringsWithStringBuilder(string name)
        {
            // Try typing "builder." and seeing what auto-complete options ReSharper gives you.
            StringBuilder builder = new StringBuilder(100);
            builder.Append("Hello, ");
            builder.Append(name);
            return builder.ToString();
        }
    }
}
