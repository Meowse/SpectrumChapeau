using System;

namespace HelloWorld
{
    class Program
    {
        private const string LOWER_CASE_INSTRUCTOR_NAME = "mickey";

        static void Main()
        {
            Console.WriteLine("Hello Seeker of Truth, please enter your first name");

            string firstName = Console.ReadLine();
            string lowerCaseFirstName = firstName.ToLower();

            if (lowerCaseFirstName.Equals(LOWER_CASE_INSTRUCTOR_NAME))
            {
                Console.WriteLine("Hello Sensei {0}! Please judge this effort to be five fingers", firstName);
            }
            else
            {
                Console.WriteLine("Hi, {0}! Sorry but discussion of grades is strictly verboten.", firstName);
            }

            Console.ReadLine();
        }
    }
}