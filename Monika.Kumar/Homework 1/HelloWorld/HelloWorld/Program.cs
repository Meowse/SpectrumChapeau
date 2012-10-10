using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Commenting and adding new code
            //Console.WriteLine("Turning in my first homework assigment.");
            //Console.ReadLine();

            // new code for extra mile
            string A;
            Console.WriteLine("Enter your first name");
            A = Console.ReadLine();

            string B;
            Console.WriteLine("Enter your Last name");
            B = Console.ReadLine();

            Console.WriteLine("User's full name is:" + " " + A + " " + B);
            string C = string.Format("Hello {0}. Is your lastname correctly spelled as {1}?", A, B);
            Console.WriteLine(C);
            string D = string.Format("Current time is: {0}", DateTime.Now);
            Console.WriteLine(D);
            Console.ReadLine();
        }
    }
}
