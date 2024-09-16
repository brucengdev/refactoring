/**
 * Duplicate the loop and remove duplicate side effects.
 * This is technically the end of split loop, but you can do more
 * like extracting the loop into separate functions
 **/

namespace SplitLoop.Refactored
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
            int youngest = people[0].Age;
            foreach(var person in people)
            {
                if(youngest > person.Age) { youngest = person.Age; }
            }

            float totalSalary = 0f;
            foreach (var person in people)
            {
                totalSalary += person.Salary;
            }

            Console.WriteLine("Youngest: {0}, Total salary: {1}", youngest, totalSalary);
        }
    }
}
