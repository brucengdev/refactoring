namespace PullUpMethod.Refactored
{
    internal class Employee: Party
    {
        public int Id { get; }
        public float MonthlyCost { get; }

        public Employee(string name, int id, int monthlyCost)
            :base(name)
        { 
            Id = id;
            MonthlyCost = monthlyCost;
        }
    }
}
