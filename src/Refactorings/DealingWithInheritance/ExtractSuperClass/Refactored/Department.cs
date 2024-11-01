namespace ExtractSuperClass.Refactored
{
    internal class Department: Party
    {
        private Employee[] _staff;
        public Department(string name, Employee[] staff): base(name)
        {
            _staff = staff;
        }

        public Employee[] Staff => (Employee[])_staff.Clone();
        public override float MonthlyCost
        {
            get
            {
                return _staff.Select(e => e.MonthlyCost)
                    .Sum();
            }
        }

        public int HeadCount => _staff.Length;
    }
}
