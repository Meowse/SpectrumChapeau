using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploringCSharp
{
    public class CodeSamples
    {
        public string SaysHello(string name)
        {
            return "Hello, " + name;
        }

        public string SaysHello2(string name)
        {
            // try googling "string formatting in C#"
            return null;
        }

        public string SaysHello2(string name)
        {
            // try Resharper
            return null;
        }

        public string SaysHello3(string name)
        {
            // Extra Credit: try googling "convert byte array to string C#"
            return null;
        }




        public string SaysHello2(string name)
        {
            return string.Format("Hello, {0}", name);
        }
    }
}
