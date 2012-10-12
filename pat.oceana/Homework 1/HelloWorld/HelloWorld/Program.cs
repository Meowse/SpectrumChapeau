using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //request user name
            string requestName = "\nHello, Please enter your name, then press Enter to continue.";
            Console.WriteLine(requestName);
            
            //capture name input
            string inputName;
            inputName = Console.ReadLine();

            //convert name input to proper case
            inputName = FormatProperCase(inputName);
            
            //do comparison and respond appropriately
            if (inputName.Equals("Mickey"))
            {
                Console.Write("Hi {0}, I would love to get a PASS for this assignment?", inputName);    
            }
            else
            {
                Console.Write("Hi {0}, I'm not at liberty to discuss my grade with anyone other than the instructor.", inputName);
            }

            Console.ReadLine();
        }  

        /// <summary>
        /// method to convert a string to proper case
        /// </summary>
        /// <param name="str">value we want converted</param>
        /// <returns></returns>
        public static string FormatProperCase(string str)
        {
            // if not value is provided return an empty string
            if (string.IsNullOrEmpty(str))
                return string.Empty;
            
            //if the stirng is less than 2 characters return it upper case
            if (str.Length < 2)
                return str.ToUpper();
            
            //let's start with the first character (make upper case)
            string converted = str.Substring(0, 1).Trim().ToUpper();
            
            //now loop through the rest of the string converting where needed
            for (int i = 1; i < str.Length; i++)
            {
                converted = (Char.IsUpper(str[i])) ? converted += " " : converted += str[i];
            }
        
            //return the formatted string
            return converted;
        }
    }
}
 