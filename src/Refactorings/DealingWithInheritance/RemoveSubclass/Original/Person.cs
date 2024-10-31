namespace RemoveSubclass.Original
{
    internal class Person
    {
        private string _name;
        public Person(string name)
        {
            _name = name;
        }

        public virtual string GetGenderCode() => "X";
    }

    internal class Male: Person
    {
        public Male(string name): base(name) { }
        public override string GetGenderCode() => "M";
    }

    internal class Female: Person
    {
        public Female(string name): base(name) { }
        public override string GetGenderCode() => "F";
    }
}
