using System;

namespace HelloWorld
{
    internal class Program
    {
        private const string LOWER_CASE_INSTRUCTOR_FIRST_NAME = "mickey";

        private static void Main()
        {
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();

            if (firstName.Length == 0)
            {
                Console.WriteLine("No name entered.");
            }
            else
            {
                Console.WriteLine("Hello {0}\n", firstName);

                if (firstName.ToLower() == LOWER_CASE_INSTRUCTOR_FIRST_NAME)
                {
                    Console.WriteLine(
                        "I believe I deserve a grade of A+ since I was able to do all the extra credit!  Thank you");
                }
                else
                {
                    Console.WriteLine(
                        "I am so sorry I cannot discuss my grade with you because you are not the instructor.");
                }
            }
            Console.WriteLine("Please press any key to exit.");
            Console.ReadKey();
        }
    }
}
