﻿using System;

namespace HelloWorld
{
    class InteractiveWelcome
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?:");
            Console.Write("Hello, {0}!", Console.ReadLine());

           
            Console.ReadKey();
        }
    }
}
