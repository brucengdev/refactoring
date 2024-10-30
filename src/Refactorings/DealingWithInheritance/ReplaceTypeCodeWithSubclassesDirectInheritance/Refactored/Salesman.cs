namespace ReplaceTypeCodeWithSubclassesDirectInheritance.Refactored
{
    internal class Salesman: Employee
    {
        public Salesman(string name): base(name) { }
        protected override string Type {
            get {
                return "salesman";
            }
        }
    }
}
