using System;

namespace HelloWorld
{
    class Program
    {
        private const string LOWER_CASE_INSTRUCTOR_NAME = "mickey"; 

        static void Main()
        {
           
            string InstructorsNameEnteredAtLogin;
            string instructorsNameDefinedAsConstant;
            bool InstructorsNameMatches;

            instructorsNameDefinedAsConstant = LOWER_CASE_INSTRUCTOR_NAME;
           
            Console.WriteLine("Please enter your first name - upper or lower case or mixed case ok");
           
            InstructorsNameEnteredAtLogin = Console.ReadLine();


           InstructorsNameMatches = string.Equals(instructorsNameDefinedAsConstant,InstructorsNameEnteredAtLogin,StringComparison.OrdinalIgnoreCase); // this is not case sensisive

            if (InstructorsNameMatches)
            {
                Console.WriteLine("Hi " + InstructorsNameEnteredAtLogin +
                                  ", I will recieve a grade of True if I get a grade at all, otherwise it will be false!");
            }
            else
            {
                Console.WriteLine("Hi " + InstructorsNameEnteredAtLogin +
                                  ", your name must be Mickey if you want to know what grade I think Mickey should give me.");
            }
            Console.ReadKey();
        }
    }
}

