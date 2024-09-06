/**
 * In this example, Client wants to know a person's manager
 * and has to access the manager's name through the person's department.
 * So when the department's implementation change, it affects all client code.
 * We can reduce this coupling by allow access to the manager directly from Person.
 **/
namespace HideDelegate.Original
{
    public class Department
    {
        public string Manager { get;set; }
    }

    public class Person
    {
        public string Name { get;set; }
        public Department Department { get;set; }
    }

    public class Client
    {
        public void PrintProfile(Person person)
        {
            Console.WriteLine("Name: {0}", person.Name);
            var manager = person.Department.Manager;
            Console.WriteLine("Manager: {0}", manager);
        }
    }
}
