

using DataClass.Original;

/**
 * In this refactored version, the behaviors are moved into the class
 * so the class is not a dumb data class anymore.
 **/

namespace DataClass.Refactored
{
    public class Profile
    {
        private string Name { get;set; }
        private int Age { get;set; }
        private string Salutation { get;set; }

        public Profile(string name, int age, string salutation)
        {
            Name = name;
            Age = age;
            Salutation = salutation;
        }

        public void Print()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Salutation: {0}", Salutation);
        }
    }

    public class DataClassExample
    {
        public void PrintProfile()
        {
            var profile = new Profile("Tom", 22, "Mr.");
            profile.Print();
        }
    }
}
