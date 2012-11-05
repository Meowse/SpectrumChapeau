using System.Collections.Generic;

namespace ReferenceTypesExamples
{
    // This is the declaration of the class "Person".  This is what defines "Person-ness" -- what it means
    // to be a "Person" object.
    //
    // The keyword "public" means "other classes and projects can see, and make use of, this 'Person' concept."
    //
    // The keyword "class" means "This thing called 'Person' is a class, which means you can make instances
    // of it, and it's a reference type, and when you assign a value of type 'Person' to a variable of type
    // 'Person', we won't make a copy of the values, we'll just copy over the reference to the same 'Person' object."
    public class Person
    {
        // This is the declaration of the "Name" property of the class "Person".
        // This says, "Anything that is of type 'Person' has a 'Name' property,
        // and that 'Name' property is of type string."
        //
        // Visual Studio relies on this information to enable "IntelliSense", which is
        // what lets it fill in "Name" as an option when you type "somePerson."

        // This declares a "field" named "_name", which only this class can see (because it is "private").
        // A "field" is just a variable that is associated with each instance of the class.
        //
        // Since this variable is used to hold a value for a property (the property "Name", defined below),
        // this particular kind of field is called a "backing field".
        private string _name;

        // This declares a "property" named "Name", which anybody can get or set.
        // It's like a variable (in that you can get and set its value), but "behind the scenes" 
        // it actually calls the "get" and "set" methods.
        //
        // And in the "set" method, we not only set the value of _name to the new value ... we also
        // add the new value to the _nameHistory audit trail.
        //
        // This property does not actually have a memory location of its own.  It uses the "_name"
        // backing field as its "memory".
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                _nameHistory.Add(value);
            }
        }

        public int Age { get; set; }
        public string Address { get; set; }
        public Person BestFriend { get; set; }


        // This says that I have a list of strings, that only I can see, that is the history of this person's names.
        // The keyword "readonly" says that I will always have the *same* List<string> object being stored in _nameHistory
        private readonly List<string> _nameHistory = new List<string>();
        
        public List<string> NameHistory
        {
            get { return new List<string>(_nameHistory); }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
