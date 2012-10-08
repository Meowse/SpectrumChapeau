using System;


// Bryna Shane
// .Net Development Foundations, Fall 2012
// Homework Assignment #1
//
// Task:  Modify the application code so that it tells me what grade to give you on the assignment.
//
//  Extra Credit:
// 1. Prompt the user to enter his or her name.
// 2. Get the user's input.
// 3. Greet the user by name.


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables to hold user name and grade values
            string userName = string.Empty;
            string userGrade = string.Empty;
            
            //Interrogate the user for name and store the result in the userName variable
            Console.Write("\nHello! Please enter your name: ");
            userName = Console.ReadLine();

            //Interrogate the user for desired grade and store the result in the userGrade variable
            Console.Write("\n\n{0}, please enter the grade you think you deserve:  ", userName);
            userGrade = Console.ReadLine();

            //Spell it out, then pause the app for readability
            Console.Write("\n\n{0}, you DO deserve a {1}!", userName, userGrade);
            Console.ReadKey();
        }
    }
}
