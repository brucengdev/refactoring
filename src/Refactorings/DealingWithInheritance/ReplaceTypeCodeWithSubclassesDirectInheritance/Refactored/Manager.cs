namespace ReplaceTypeCodeWithSubclassesDirectInheritance.Refactored
{
    internal class Manager: Employee
    {
        public Manager(string name): base(name) { }
        protected override string Type {
            get {
                return "manager";
            }
        }
    }
}
