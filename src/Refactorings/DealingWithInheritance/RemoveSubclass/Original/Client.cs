namespace RemoveSubclass.Original
{
    internal class Client
    {
        private IEnumerable<Person> _persons = new List<Person>();
        public void SetData((string, char)[] personData)
        {
            _persons = personData
                .Select(d =>
                {
                    var (name, gender) = d;
                    switch(gender)
                    {
                        case 'M': return new Male(name) as Person;
                        case 'F': return new Female(name) as Person;
                        case 'X': return new Person(name);
                    }
                    throw new ArgumentException($"Invalid gender {gender}");
                }).ToList();
        }
        public int GetNumberOfMales()
        {
            int numberOfMales = _persons.Where(p => p is Male).Count();
            return numberOfMales;
        }
    }
}
