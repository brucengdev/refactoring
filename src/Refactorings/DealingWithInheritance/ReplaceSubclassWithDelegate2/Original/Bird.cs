
namespace ReplaceSubclassWithDelegate2.Original
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
        public static Bird Create(BirdData data) { 
            switch(data.Type)
            {
                case "EuropeanSwallow":
                    return new EuropeanSwallow(data);
                case "AfricanSwallow":
                    return new AfricanSwallow(data);
                case "NorwegianBlueParrot":
                    return new NorwegianBlueParrot(data);
                default:
                    return new Bird(data);
            }
        }

        public string Name { get; set; }

        protected string _plumage;
        public virtual string Plumage { get
            {
                return string.IsNullOrEmpty(_plumage)? "average": _plumage;
            }
        }
        public Bird(BirdData data)
        {
            
            Name = data.Name;
            _plumage = data.Plumage;
        }

        public virtual float? AirSpeedVelocity
        {
            get
            {
                return null;
            }
        }
    }

    internal class EuropeanSwallow: Bird
    {
        public EuropeanSwallow(BirdData data): base(data) { }

        public override float? AirSpeedVelocity => 35;
    }

    internal class AfricanSwallow : Bird
    {
        private int _numberOfCoconuts;
        public AfricanSwallow(BirdData data) : base(data) 
        {
            _numberOfCoconuts = data.NumberOfCoconuts;
        }

        public override float? AirSpeedVelocity => 40 - 2 * _numberOfCoconuts;
    }
    internal class NorwegianBlueParrot : Bird
    {
        private bool _isNailed;
        private int _voltage;
        public NorwegianBlueParrot(BirdData data) : base(data)
        {
            _voltage = data.Voltage;
            _isNailed = data.IsNailed;
        }

        public override string Plumage
        {
            get
            {
                if(_voltage > 100) return "scorched";
                else return string.IsNullOrEmpty(_plumage)? "beautiful": _plumage;
            }
        }

        public override float? AirSpeedVelocity
        {
            get
            {
                return _isNailed? 0: (10 + _voltage / 10);
            }
        }
    }
}
