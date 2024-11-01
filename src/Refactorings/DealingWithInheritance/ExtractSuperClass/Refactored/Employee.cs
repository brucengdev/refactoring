namespace ExtractSuperClass.Refactored
{
    internal class Employee: Party
    {
        private int _id;
        private float _monthlyCost;
        public Employee(string name, int id, float monthlyCost): base(name)
        {
            _id = id;
            _monthlyCost = monthlyCost;
        }

        public int Id { get { return _id; } }
        public override float MonthlyCost { get { return _monthlyCost; } }
    }
}
