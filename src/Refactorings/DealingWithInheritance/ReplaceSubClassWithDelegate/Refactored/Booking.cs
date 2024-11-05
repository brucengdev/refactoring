namespace ReplaceSubClassWithDelegate.Refactored
{
    internal class Booking
    {
        protected Show _show { get; }
        protected DateTime _date { get; }
        public Booking(Show show, DateTime date, bool isPeakDay)
        {
            _show = show;
            _date = date;
            IsPeakDay = isPeakDay;
        }

        public bool IsPeakDay { get; set; }
        public virtual bool HasTalkback { 
            get {
                return _show.HasTalkBack && IsPeakDay;
            }
        }

        public virtual double BasePrice
        {
            get
            {
                var result = _show.Price;
                if(IsPeakDay) {
                    result += Math.Round(_show.Price * 0.15);
                }
                return result;
            }
        }
    }
}
