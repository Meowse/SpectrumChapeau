using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReferenceTypesExamples
{
    public class ReferenceTypes
    {
        public void SharedReferenceExample()
        {
            Person mickey = new Person("Mickey Phoenix", 40);

            // Does not copy values from the "mickey" object to the "instructor" object
            // Just copies the reference to the object (the pointer to the memory location of the object) from "mickey" to "instructor"
            Person instructor = mickey;

            Console.WriteLine(mickey.Name);
            Console.WriteLine(instructor.Name);

            instructor.Name = "Michael Phoenix";

            Console.WriteLine(mickey.Name); // prints out "Michael Phoenix"

            mickey.Age = 41;

            Console.WriteLine(instructor.Age); // prints out "41"
        }

        public void TwoDifferentObjectsExample()
        {
            Person mickey = new Person("Mickey Phoenix", 40);
            Person susan = new Person("Susan Winthrop", 41);

            mickey.Address = "1724 17th Ave., Seattle, WA 98122";

            // This copies a value from the "mickey" object to the "eva" object -- specifically, the value that is "the location
            // of the address string".
            susan.Address = mickey.Address;

            // All this does is change the Address property of the "mickey object" -- not the Address property of the "eva object"
            mickey.Address = "301 1st St., Tukwila, WA 98188";

            Console.WriteLine(susan.Address); // what will this print?
        }

        public void TwoDifferentObjectsWithSharedReference()
        {
            Person mickey = new Person("Mickey Phoenix", 40); // "the object formerly known as 'mickey'
            Person susan = new Person("Susan Winthrop", 41); // "the object formerly known as 'susan'"

            Person joe = new Person("Joe Schmoe", 39); // "the object formerly known as 'joeschmoe'"

            mickey.BestFriend = joe; // mickey.BestFriend is now a reference to the object formerly known as joeschmoe
            susan.BestFriend = joe;  // susan.BestFriend is now a reference to the object formerly known as joeschmoe

            // Which means that any changes to the object formerly known as joeschmoe 
            // will change both the attributes of Mickey's best friend and the 
            // attributes of Susan's best friend

            joe.Name = "John Doe";

            // What will these print out?
            Console.WriteLine(mickey.BestFriend.Name);
            Console.WriteLine(susan.BestFriend.Name);

            mickey.BestFriend.Name = "Joseph Schmoeseph";

            // What will this print?
            Console.WriteLine(joe.Name);
            Console.WriteLine(mickey.BestFriend.Name);
            Console.WriteLine(susan.BestFriend.Name);
        }

        public void BreakingYourBrains()
        {
            Person mickey = new Person("Mickey Phoenix", 40); // the object formerly known as mickey
//            Person alsoMickey = mickey;
//            Person stillAnotherAliasForMickey = mickey;
//            Person anotherWayToTalkAboutTheSameObject = alsoMickey;

            Person mickeySpouse = new Person("Susan Winthrop", 41);  // the object formerly known as susan

            mickey.BestFriend = mickeySpouse;
            mickeySpouse.BestFriend = mickey;

            // What do these print?
            Console.WriteLine(mickey.BestFriend.Name);  // This will print out "Susan Winthrop"
            Console.WriteLine(mickeySpouse.BestFriend.Name);  // This will print out "Mickey Phoenix"

            // Very confusing line
            mickey.BestFriend.BestFriend.BestFriend.BestFriend.BestFriend.Name = "Bartholomew Cubbins";

            // What do these print?
            Console.WriteLine(mickey.Name);  // Prints "Mickey Phoenix"
            Console.WriteLine(mickeySpouse.Name); // Prints "Bartholomew Cubbins"

            // Slightly less confusing equivalent to "Very confusing line" above, with 
            // interim variables used to give names to things in between.
            Person mickeysBestFriend = mickey.BestFriend;
            Person mickeyAgain = mickeysBestFriend.BestFriend;
            Person stillMickeysBestFriend = mickeyAgain.BestFriend;
            Person onceAgainMickey = stillMickeysBestFriend.BestFriend;
            Person yepStillMickeysSpouse = onceAgainMickey.BestFriend;
            yepStillMickeysSpouse.Name = "Bartholomew Cubbins, III";

            // What do these print?
            Console.WriteLine(mickey.Name); // Prints "Mickey Phoenix"
            Console.WriteLine(mickeySpouse.Name); // Prints "Bartholomew Cubbins, III"

            // Analysis question: which variables now hold references to "the object formerly known as susan"?
            //            mickeySpouse
            //            mickeysBestFriend
            //            stillMickeysBestFriend
            //            yepStillMickeysSpouse

            // And which hold references to "the object formerly known as mickey"?
            //            mickey
            //            mickeyAgain
            //            onceAgainMickey

            // All of the following lines change the Name property of the object formerly known as mickey
            mickey.Name = "Hermione Granger";
            mickeyAgain.Name = "Harry Potter";
            onceAgainMickey.Name = "Severus Snape";
            mickeyAgain.Name = "Mickey Phoenix";
            mickeySpouse.BestFriend.Name = "Weasley";
            yepStillMickeysSpouse.BestFriend.Name = "Luna";
            mickey.BestFriend.BestFriend.Name = "Mickey Phoenix";

            // This declares a named bucket, "hello", which holds a reference to a string object
            // somewhere in memory.  
            string hello;

            // This creates a "string constant" with the contents "Hello World", which lives
            // somewhere in the computer's memory.  It then copies the location of that
            // string constant, the address of that string constant, into the location named "hello"
            hello = "Hello World";

            // This looks up the string constant whose address is contained in the bucket named
            // "hello", and prints it out on the console.
            Console.WriteLine(hello);

            // This makes a new string by combining "Goodbye Cruel World" and ", I'm leaving you today",
            // and stores it in some location in memory.
            hello = "Goodbye Cruel World" + ", I'm leaving you today";

            Console.WriteLine(hello);

            // This replaces that reference with a reference to a new string constant.
            // The garbage collector can now garbage collect the string that was constructed by the addition above
            hello = "Goodbye";

            Console.WriteLine(hello);
        }

        public void AnsweringNazeesQuestionAboutAuditTrails()
        {
            Person mickey = new Person("Mickey Phoenix", 40);
            
            mickey.Name = "Meowse";
            // Actually doing this, behind the scenes
            // mickey.set_Name("Meowse");

            Console.WriteLine(mickey.Name);            
            // Actually doing this, behind the scene
            // Console.WriteLine(mickey.get_Name());

            mickey.Name = "Moose";
            mickey.Name = "Michael David Phoenix";
            mickey.Name = "Mickey Phoenix";
            foreach (string name in mickey.NameHistory)
            {
                Console.WriteLine("Name was: " + name);
            }
        }
    }
}
