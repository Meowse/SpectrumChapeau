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
            return string.Format("Hello, {0}", name);
        }

        public string GreetsByCombiningStringsWithStringBuilder(string name)
        {
            var builder = new StringBuilder("Hello, ");
 
            builder.Append(name);
            return builder.ToString();
        }
    }
}
