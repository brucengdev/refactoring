namespace PullUpMethod.Original
{
    internal class Employee: Party
    {
        public string Name { get; }
        public int Id { get; }
        public float MonthlyCost { get; }

        public Employee(string name, int id, int monthlyCost)
        {
            Name = name;
            Id = id;
            MonthlyCost = monthlyCost;
        }
    }
}
