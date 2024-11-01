namespace ExtractSuperClass.Original
{
    internal class Employee
    {
        private string _name;
        private int _id;
        private float _monthlyCost;
        public Employee(string name, int id, float monthlyCost)
        {
            _name = name;
            _id = id;
            _monthlyCost = monthlyCost;
        }

        public string Name { get { return _name; } }
        public int Id { get { return _id; } }
        public float MonthlyCost { get { return _monthlyCost; } }
        public float AnnualCost { get { return MonthlyCost * 12;  } }
    }
}
