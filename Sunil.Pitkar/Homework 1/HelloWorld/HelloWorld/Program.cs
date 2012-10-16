using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           // Homework 1 :  Extra credit which i has missed seeing on the class website in the week of 10/8
            Console.WriteLine("Hello stranger, whats ur name?");
            string name = Console.ReadLine();
            if (name == "")
            {
                Console.WriteLine("Not a valid name, hit any key to exit.");
        
            }
            else
            {
                Console.WriteLine("Hello " + name);   
            }
            
            Console.ReadKey();
        }
    }
}
