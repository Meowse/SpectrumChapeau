using System;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Homework 1 :  Extra extra credit which i has missed seeing on the class website in the week of 10/8

            const string instructorFirstNameLower = "mickey";

            Console.WriteLine("Hello stranger, whats ur name?");
            string name = Console.ReadLine();
            
            name = name.Trim();
            bool nameLengthNotZero = name.Length != 0;
            
            if (nameLengthNotZero)
            {
                if(name.Length >= instructorFirstNameLower.Length)
                {
                   //Assuming input is more than 6 characters else  it will crash, need to fix it. 
                   string firstName = name.Substring(0, 6);

                   if (instructorFirstNameLower == firstName.ToLower())
                    {
                        Console.WriteLine("Hello master... please grant me a passing grade.");
                    }
                   else
                   {
                       Console.WriteLine("Sorry " + name + " cant have a grading discussion with you.");
                   }
                }
                else
                {
                    Console.WriteLine("Sorry " + name + " cant have a grading discussion with you.");
                }
            }
            else
            {
                Console.Write("Sorry, invalid input.");
            }
            Console.ReadKey();
            }
        }
    }
