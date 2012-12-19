using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person user = new Person("123456789");
            user.Name = "Joe Schmoe";
            user.Age = 29;

            Person user2 = new Person("987654321", "Mickey Phoenix", 40);

//            string tempName = user.Name;
//            user.Name = user2.Name;
//            user2.Name = tempName;

            Person temp = user;
            user = user2;
            user2 = temp;

            // user = user2;
            // user = null;

            Console.WriteLine("The user's name is " + user.Name + ", and his SSN is " + user.SocialSecurityNumber);
            Console.WriteLine("user 2's name is " + user2.Name + ", and his SSN is " + user2.SocialSecurityNumber);

            Console.ReadKey();
        }
    }
}
