using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I would like to get a passing grade on assignment 1.");
            Console.ReadKey();
            // Extra credit
            Console.Write(" What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("Hello {0}, how are you? {0}", name);
            Console.ReadLine();

            // Extra Extra Credit

            //Console.WriteLine("what is your first name?");
            //String Firstname = Console.ReadLine();

            //if (Firstname == "Mickey")
              //  Console.WriteLine("You can request your desired grade");
            //Console.ReadLine();
             //else
            
               // Console.WriteLine("Can't discuss your grade because you are not the instructor");
            
           
        }
    }
}
