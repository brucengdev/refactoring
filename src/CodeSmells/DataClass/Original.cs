/**
 * Data classes are dumb classes that are manipulated everywhere
 * They are an issue when the behaviors are in the wrong place, they
 * are in the clients using the class instead of inside the class itself.
 * 
 * Solve this with
 * - Encapsulate Record
 * - Remove setting method
 * - Move behaviors from clients to the class for reuse
 **/

namespace DataClass.Original
{
    public class Profile
    {
        public string Name { get;set; }
        public int Age { get;set; }
        public string Salutation { get;set; }
    }

    public class DataClassExample
    {
        public void PrintProfile()
        {
            var profile = new Profile();
            Console.WriteLine("Name: {0}", profile.Name);
            Console.WriteLine("Age: {0}", profile.Age);
            Console.WriteLine("Salutation: {0}", profile.Salutation);
        }
    }
}
