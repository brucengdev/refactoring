namespace ExtractSuperClass.Original
{
    internal class Department
    {
        private string _name;
        private Employee[] _staff;
        public Department(string name, Employee[] staff)
        {
            _name = name;
            _staff = staff;
        }

        public Employee[] Staff => (Employee[])_staff.Clone();
        public string Name => _name;
        public float TotalMonthlyCost
        {
            get
            {
                return _staff.Select(e => e.MonthlyCost)
                    .Sum();
            }
        }

        public int HeadCount => _staff.Length;

        public float TotalAnnualCost => TotalMonthlyCost * 12;
    }
}
