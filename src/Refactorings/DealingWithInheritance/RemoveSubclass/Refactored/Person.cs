namespace RemoveSubclass.Refactored
{
    internal class Person
    {
        private string _name;
        private char _genderCode;
        public Person(string name, char genderCode)
        {
            _name = name;
            _genderCode = genderCode;
        }

        public static Person Create(string name, char gender)
        {
            switch (gender)
            {
                case 'M': return new Person(name, 'M');
                case 'F': return new Person(name, 'F');
                case 'X': return new Person(name, 'X');
            }
            throw new ArgumentException($"Invalid gender {gender}");
        }

        public virtual char GetGenderCode() => _genderCode;

        public bool IsMale() => GetGenderCode() == 'M';
    }
}
