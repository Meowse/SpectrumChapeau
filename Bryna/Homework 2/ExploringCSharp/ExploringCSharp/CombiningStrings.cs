
// Bryna Shane
// .Net Development Foundations, Fall 2012
// Homework Assignment #2
// October 17, 2012
//
// CombiningStrings.cs
//
// Tasks:  Make all the tests work.
// Extra Credit:  Make the extra credit tests work.


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
           //google "string formatting in C#"
            string result = string.Format("Hello, {0}",name);
            return result;
        }

        public string GreetsByCombiningStringsWithStringBuilder(string name)
        {
            StringBuilder builder = new StringBuilder(100);
            
            // Try typing "builder." and seeing what auto-complete options ReSharper gives you.
            
            string s = GreetsByCombiningStringsWithFormats(name);
            StringBuilder t = builder.Append(s);
            return t.ToString();
        }
    }
}
