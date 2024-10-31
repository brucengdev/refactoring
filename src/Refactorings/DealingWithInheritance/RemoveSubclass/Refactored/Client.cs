namespace RemoveSubclass.Refactored
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
                    return Person.Create(name, gender);
                }).ToList();
        }
        public int GetNumberOfMales()
        {
            int numberOfMales = _persons.Where(p => p.IsMale()).Count();
            return numberOfMales;
        }
    }
}
