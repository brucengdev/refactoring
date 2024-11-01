namespace ExtractSuperClass.Refactored
{
    internal abstract class Party
    {
        public string _name;
        public Party(string name)
        {
            _name = name;
        }
        public string Name => _name;

        public virtual float MonthlyCost 
            => throw new NotImplementedException("subclasses must implement MonthlyCost");

        public float AnnualCost { get { return MonthlyCost * 12; } }
    }
}
