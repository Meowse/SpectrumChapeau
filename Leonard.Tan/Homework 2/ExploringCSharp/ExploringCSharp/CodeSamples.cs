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
            return string.Format("Hello, {0}", name);
        }

        public string SaysHello3(string name)
        {
            // try Resharper
            return string.Format("Hello, {0}", name);
        }

        public string SaysHello4    (string name)
        {
            // Extra Credit: try googling "convert byte array to string C#"
            // Conde References from http://www.dotnetperls.com/convert-string-byte-array
            byte[] array =
            {
                72,
                101,
                108,
                108,
                111,
                44,
                32,
                76,
                101,
                111,
                110,
                97,
                114,
                100
	        };

            return ASCIIEncoding.ASCII.GetString(array);
        }


    }
}
