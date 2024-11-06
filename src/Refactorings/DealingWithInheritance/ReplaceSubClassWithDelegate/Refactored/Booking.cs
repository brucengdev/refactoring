namespace ReplaceSubClassWithDelegate.Refactored
{
    internal class Booking
    {
        public Show Show { get; }
        protected DateTime _date { get; }
        
        protected PremiumBookingDelegate _premiumDelegate;
        public Booking(Show show, DateTime date, bool isPeakDay)
        {
            Show = show;
            _date = date;
            IsPeakDay = isPeakDay;
        }

        public bool IsPeakDay { get; set; }
        public bool HasTalkback { 
            get {
                if(_premiumDelegate != null)
                {
                    return _premiumDelegate.HasTalkback;
                }
                return Show.HasTalkBack && IsPeakDay;
            }
        }

        public double BasePrice
        {
            get
            {
                var result = Show.Price;
                if(IsPeakDay) {
                    result += Math.Round(Show.Price * 0.15);
                }
                if(_premiumDelegate != null)
                {
                    result = _premiumDelegate.ExtendBasePrice(result);
                }
                return result;
            }
        }

        public virtual bool HasDinner
        {
            get
            {
                return _premiumDelegate == null? false
                    : _premiumDelegate.HasDinner;
            }
        }

        public void BePremium(Extras extras)
        {
            _premiumDelegate = new PremiumBookingDelegate(this, extras);
        }
    }
}
