using System;
using System.Threading; 
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Seeker of Truth, please enter your first name");
            //Console.WriteLine("Please rate this effort as Passing");
            string Fname = Console.ReadLine();
            string Cname = Fname.ToLower(); //preserving Fname in state it is entered, i.e., all caps, first char capitalized...
            string Instructor = "mickey";
            if (Cname.Equals(Instructor))
            {
                Console.WriteLine("Hello Sensei {0}! Please judge this effort to be five fingers", Fname);
                Console.ReadLine();
            }
            else //(Fname.Equals("Mickey"))
            {
                Console.WriteLine("Hi, {0}! Sorry but discussion of grades is strictly verboten.", Fname);
                Console.ReadLine();
            }
       }
    }
}