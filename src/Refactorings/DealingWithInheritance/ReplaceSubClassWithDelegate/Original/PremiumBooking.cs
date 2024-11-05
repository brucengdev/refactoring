namespace ReplaceSubClassWithDelegate.Original
{
    internal class PremiumBooking : Booking
    {
        private Extras _extras;
        public PremiumBooking(
            Show show,
            DateTime date, 
            bool isPeakDay,
            Extras extras) : base(show, date, isPeakDay)
        {
            _extras = extras;
        }

        public override bool HasTalkback { 
            get {
                return _show.HasTalkBack;
            }
        }

        public override double BasePrice
        {
            get
            {
                var result = base.BasePrice;
                result += _extras.PremiumFee;
                return result;
            }
        }

        public bool HasDinner
        {
            get
            {
                return _show.HasDinner && !IsPeakDay;
            }
        }
    }
}
