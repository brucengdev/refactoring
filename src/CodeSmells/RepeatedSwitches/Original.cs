/**
 * This code smell is when you see repeated switches.
 * It is troublesome because whenever you add a new switch case, you have
 * to find all the switches to add the case, and you might miss some.
 * 
 * The solution to this is to use polymorphism, there should be only
 * one switch case to create an instance of the correct subclass, depending
 * on the switch value.
 **/

namespace RepeatedSwitches.Original
{
    public enum JobType
    {
        Student,
        Doctor,
        Programmer
    }
    public class Professional
    {
        private readonly JobType _jobType;
        private readonly string _name;
        public Professional(JobType jobType, string name)
        {
            _jobType = jobType;
            _name = name;
        }

        public string Greet()
        {
            switch(_jobType)
            {
                case JobType.Student:
                    return $"Hello, student {_name}!";
                case JobType.Doctor:
                    return $"Hello, Dr. {_name}!";
                case JobType.Programmer:
                    return $"Hello, {_name} the engineer!";
                default: 
                    return $"Hello, {_name}!";
            }
        }

        public float GetSalary()
        {
            switch(_jobType)
            {
                case JobType.Student:
                    return 0;//unemployed
                case JobType.Doctor:
                    return 100000;
                case JobType.Programmer:
                    return 5000;
                default:
                    return 0;
            }
        }
    }
}
