﻿/**
 * Duplicate the loop and remove duplicate side effects.
 * This is technically the end of split loop, but you can do more
 * like extracting the loop into separate functions
 **/

namespace SplitLoop.Extra
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
            var youngest = GetYoungest(people);

            var totalSalary = GetTotalSalary(people);

            Console.WriteLine("Youngest: {0}, Total salary: {1}", youngest, totalSalary);
        }

        private int GetYoungest(Person[] people)
        {
            return people.Aggregate(people[0].Age,
                (int age, Person person) => age < person.Age? age: person.Age);
        }

        private float GetTotalSalary(Person[] people)
        {
            return people.Aggregate(0f, (float salary, Person person) => salary + person.Salary);
        }
    }
}
