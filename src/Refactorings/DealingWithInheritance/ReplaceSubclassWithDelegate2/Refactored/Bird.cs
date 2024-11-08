
namespace ReplaceSubclassWithDelegate2.Refactored
{
    public class BirdData
    {
        public string Type;
        public string Name;
        public string Plumage;
        public int NumberOfCoconuts;
        public int Voltage;
        public bool IsNailed;
    }
    internal class Bird
    {
        private BirdDelegate _delegate;
        public static Bird Create(BirdData data) { 
           return new Bird(data);
        }

        public string Name { get; set; }

        public string _plumage;
        public virtual string Plumage { get
            {
                return _delegate.Plumage;
            }
        }
        public Bird(BirdData data)
        {
            Name = data.Name;
            _plumage = data.Plumage;
            _delegate = CreateDelegate(data);
        }

        private BirdDelegate CreateDelegate(BirdData data)
        {
            switch(data.Type)
            {
                case "EuropeanSwallow":
                    return new EuropeanSwallowDelegate(this);
                case "AfricanSwallow":
                    return new AfricanSwallowDelegate(data, this);
                case "NorwegianBlueParrot":
                    return new NorwegianBlueParrotDelegate(data, this);
            }
            return new BirdDelegate(this);
        }

        public virtual float? AirSpeedVelocity
        {
            get
            {
                return _delegate.AirSpeedVelocity;
            }
        }
    }

    internal class BirdDelegate
    {
        protected Bird _bird;
        public BirdDelegate(Bird bird)
        {
            _bird = bird;
        }
        public virtual float? AirSpeedVelocity => null;
        public virtual string Plumage => string.IsNullOrEmpty(_bird._plumage) ? "average" : _bird._plumage
    }

    internal class EuropeanSwallowDelegate: BirdDelegate
    {
        public EuropeanSwallowDelegate(Bird bird): base(bird) { }
        public override float? AirSpeedVelocity => 35;
    }

    internal class AfricanSwallowDelegate: BirdDelegate
    {
        private int _numberOfCoconuts;
        public AfricanSwallowDelegate(BirdData data, Bird bird): base(bird)
        {
            _numberOfCoconuts = data.NumberOfCoconuts;
        }

        public override float? AirSpeedVelocity => 40 - 2 * _numberOfCoconuts;
    }

    internal class NorwegianBlueParrotDelegate: BirdDelegate
    {
        private bool _isNailed;
        private int _voltage;
        public NorwegianBlueParrotDelegate(BirdData data, Bird bird): base(bird)
        {
            _voltage = data.Voltage;
            _isNailed = data.IsNailed;
        }
        public override string Plumage
        {
            get
            {
                if (_voltage > 100) return "scorched";
                else return string.IsNullOrEmpty(_bird._plumage) ? "beautiful" 
                        : _bird._plumage;
            }
        }

        public override float? AirSpeedVelocity
        {
            get
            {
                return _isNailed ? 0 : (10 + _voltage / 10);
            }
        }
    }

}
