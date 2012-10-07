using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 10/07/2012 Initial Leonard Tan cftan@uw.edu

            //        Declaration of variables

            string strName, strTime;
            DateTime CurrTime = DateTime.Now;
            DateTime NoonToday = Convert.ToDateTime("12:00:00 PM");

            //        Greetings depending on time of the day
            if (DateTime.Now > NoonToday)
            {
            //    Console.WriteLine("Good Morning!");
                strTime = "Afternoon";
            }
            else
            {
                //Console.WriteLine("Good Afternoon!");
                strTime = "Morning";
            }


            Console.WriteLine();
            Console.WriteLine("May I know what is your first name?\n");
            strName = Console.ReadLine();
            Console.WriteLine("Good {0} {1}!",strTime, strName);

            
            //          Determine Statement by first name

            if (string.Equals(strName, "Mickey", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("What's the grade do you think I deserved?");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Thank you for using this program and Goodbye!");
                Console.ReadKey();
            }

            
//Prompt the user to enter his or her name.
//Get the user's input (try googling: "C# read console input").
//Greet the user by name (try googling: "format output in C#").

//Extra extra credit:
//If the user's name is "Mickey", request your desired grade; if not, explain that you cannot discuss your grade with the user because he or she is not the instructor. (try googling: "compare strings in C#")
        

        }
    }
}
