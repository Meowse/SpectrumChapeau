using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your first name:");
            string userInput = Console.ReadLine();

            if (userInput != null)
            {
                if (userInput.Length < 1) Console.WriteLine("No name entered.");
                else
                {
                    Console.WriteLine("Hello {0}\n", userInput);

                    if (userInput.ToLower() == "mickey")
                        Console.WriteLine(
                            "I believe I deserve a grade of A+ since I was able to do all the extra credit!  Thank you {0}\n",
                            userInput + "!");
                    else
                        Console.WriteLine("I am so sorry {0}\n",
                                          userInput +
                                          ", I cannot discuss my grade with you because you are not the instructor.");
                }
            }
            Console.WriteLine("Please press any key to exit.");
            Console.ReadKey();
        }
    }
}
