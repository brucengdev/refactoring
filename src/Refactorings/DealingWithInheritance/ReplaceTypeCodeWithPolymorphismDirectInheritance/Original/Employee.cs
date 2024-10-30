namespace ReplaceTypeCodeWithPolymorphismDirectInheritance.Original
{
    internal class Employee
    {
        private string _name { get; set; }
        private string _type { get; set; }
        public Employee(string name, string type)
        {
            ValidateType(type);
            _name = name;
            _type = type;
        }

        private void ValidateType(string type)
        {
            if(!(new string[] {"engineer", "manager", "salesman"}).Contains(type))
            {
                throw new ArgumentException($"Invalid employee type {type}");
            }
        }

        public override string ToString()
        {
            return $"{_name} ({_type})";
        }
    }
}
