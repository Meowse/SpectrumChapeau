using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string str;
            string compare_string;
            bool result;

            compare_string = "Mickey";
           
            Console.WriteLine("Please enter your first name");
           
            str = Console.ReadLine();


           //if (str == "Mickey") // Check string this works but literal

            result = string.Equals(compare_string,str,StringComparison.OrdinalIgnoreCase); // this is not case sensisive

            if (result)

            {
                Console.WriteLine("Hi " + str + ", I will recieve a grade of True if I get a grade at all, otherwise it will be false!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Hi " + str+", your name must be Mickey if you want to know what grade I think Mickey should give me.");
                Console.ReadKey();
            }
        }
    }
}


//extra credit:
//prompt the user to enter his or her name.
//get the user's input (try googling: "c# read console input").
//greet the user by name (try googling: "format output in c#").
//extra extra credit:
//if the user's name is "Mickey", request your desired grade; if not, explain that you cannot discuss your grade with the user because he or she is not the instructor. (try googling: "compare strings in C#")