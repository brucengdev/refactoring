/**
 * Loops that does single thing is easier to understand and maintain.
 * When you see loops that does more than one thing, try to split them.
 **/

namespace SplitLoop.Original
{
    public class Person
    {
        public int Age { get; set; }
        public float Salary { get;set; }
    }
    public class EmployeeReporter
    {
        public void PrintYoungestAndTotalSalary(Person[] people)
        {
            float totalSalary = 0f;
            int youngest = people[0].Age;
            foreach(var person in people)
            {
                if(youngest > person.Age) { youngest = person.Age; }
                totalSalary += person.Salary;
            }

            Console.WriteLine("Youngest: {0}, Total salary: {1}", youngest, totalSalary);
        }
    }
}
