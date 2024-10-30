namespace ReplaceTypeCodeWithPolymorphismIndirectInheritance.Original
{
    internal class EmployeeType
    {
        private string _value;
        public EmployeeType(string value) {
            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }

        public string GetCapitalizedType()
        {
            return ToString().Substring(0, 1).ToUpper()
                + ToString().Substring(1).ToLower();
        }
    }

    internal class Engineer: EmployeeType
    {
        public Engineer(): base("engineer") { }
        public override string ToString()
        {
            return "engineer";
        }
    }
    internal class Manager: EmployeeType
    {
        public Manager(): base("manager") { }
        public override string ToString()
        {
            return "manager";
        }
    }
    internal class Salesman: EmployeeType
    {
        public Salesman(): base("salesman") { }
        public override string ToString()
        {
            return "salesman";
        }
    }
    internal class Employee
    {
        private string _name { get; set; }
        private EmployeeType _type { get; set; }
        public Employee(string name, EmployeeType type)
        {
            ValidateType(type);
            _name = name;
            _type = type;
        }

        private void ValidateType(EmployeeType type)
        {
            if(!(new string[] {"engineer", "manager", "salesman"}).Contains(type.ToString()))
            {
                throw new ArgumentException($"Invalid employee type {type}");
            }
        }

        public EmployeeType GetType()
        {
            return this._type;
        }

        public void SetType(string type)
        {
            _type = Employee.CreateEmployeeType(type);
        }

        public static EmployeeType CreateEmployeeType(string type)
        {
            switch(type)
            {
                case "engineer": return new Engineer();
                case "manager": return new Manager();
                case "salesman": return new Salesman();
                default: throw new ArgumentException($"Employee must not be of type {type}");
            }
        }

        public override string ToString()
        {
            return $"{_name} ({_type.GetCapitalizedType()})";
        }
    }
}
