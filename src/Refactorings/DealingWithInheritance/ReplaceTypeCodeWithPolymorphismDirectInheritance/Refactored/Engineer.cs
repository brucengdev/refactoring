namespace ReplaceTypeCodeWithPolymorphismDirectInheritance.Refactored
{
    internal class Engineer: Employee
    {
        public Engineer(string name): base(name) { }
        protected override string Type {
            get {
                return "engineer";
            }
        }
    }
}
