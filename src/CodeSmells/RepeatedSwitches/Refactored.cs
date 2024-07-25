/**
 * In this refactored version, we use polymorphism to change the behavior
 * depending on the subclass being used.
 * The repeated switches are changed to only one switch to create an instance
 * of the correct subclass.
 * Whenever you add a new type of professional, you only need to add one new switch case
 * and add a new class for the new type of professional, with all new behaviors required
 * by the abstract base class.
 **/

namespace RepeatedSwitches.Refactored
{
    public enum JobType
    {
        Student,
        Doctor,
        Programmer
    }
    public abstract class Professional
    {
        public static Professional Create(JobType jobType, string name)
        {
            switch(jobType)
            {
                case JobType.Student:
                    return new Student(name);
                case JobType.Doctor:
                    return new Doctor(name);
                case JobType.Programmer:
                    return new Programmer(name);
                default:
                    throw new ArgumentException("Invalid job type");
            }
        }
        public abstract string Greet();
        public abstract float GetSalary();
    }

    public class Student : Professional
    {
        private readonly string _name;
        public Student(string name) { _name = name; }
        public override float GetSalary() => 0;//unemployed

        public override string Greet() => $"Hello, student {_name}!";
    }

    public class Doctor : Professional
    {
        private readonly string _name;
        public Doctor(string name) { _name = name; }
        public override float GetSalary() => 10000;

        public override string Greet() => $"Hello, Dr. {_name}!";
    }

    public class Programmer : Professional
    {
        private readonly string _name;
        public Programmer(string name) { _name = name; }
        public override float GetSalary() => 5000;

        public override string Greet() => $"Hello, {_name} the engineer!";
    }
}
