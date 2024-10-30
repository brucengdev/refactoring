namespace ReplaceTypeCodeWithSubclassesDirectInheritance.Refactored
{
    internal class Employee
    {
        private string _name { get; set; }

        protected virtual string Type { get
            {
                throw new NotImplementedException();
            } 
        }
        public Employee(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return $"{_name} ({Type})";
        }

        public static Employee Create(string name, string type)
        {
            switch(type)
            {
                case "engineer": return new Engineer(name);
                case "manager": return new Manager(name);
                case "salesman": return new Salesman(name);
                default: throw new ArgumentException($"Invalid employee type {type}");
            }
        }
    }
}
