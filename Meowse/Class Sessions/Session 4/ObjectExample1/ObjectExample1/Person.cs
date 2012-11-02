namespace ObjectExample1
{
    public class Person
    {
        // "Field" -- variable that you get and set directly
        // Anyone who can see it can change it
        // I can't tell when they look at it or change it
        public string SimpleName;

        // "Property" -- variable that you get and set via methods
        // I can separately control who can see it and 
        // who can change it
        // I can tell when someone looks at it
        // I can tell when someone changes it
        public string Name { get; set; }


        // These properties (Name and Age) are both
        // a particular type of property called
        // an "auto-property" -- the getter just returns
        // the value, and the setter just sets the value --
        // and they look like "{ get; set; }"
        public int Age { get; set; }

        public string SocialSecurityNumber { get; private set; } 

        // For future reference -- how do we keep "AlphabetizedName"
        // synchronized with "FirstName" and "LastName"?
        public string FirstName { get; set; }
        public string LastName;
        public string AlphabetizedName { get; private set; }

        public Person(string socialSecurityNumber)
        {
            SocialSecurityNumber = socialSecurityNumber;
        }

        public Person(string socialSecurityNumber, string name, int age)
        {
            SocialSecurityNumber = socialSecurityNumber;
            Name = name;
            Age = age;
        }
    }
}
