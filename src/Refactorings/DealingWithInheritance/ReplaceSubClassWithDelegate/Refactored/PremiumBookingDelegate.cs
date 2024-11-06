using ReplaceSubClassWithDelegate.Original;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSubClassWithDelegate.Refactored
{
    internal class PremiumBookingDelegate
    {
        private Booking _hostBooking;
        private Extras _extras;
        public PremiumBookingDelegate(Booking hostBooking, Extras extras)
        {
            _hostBooking = hostBooking;
            _extras = extras;
        }

        public bool HasTalkback
        {
            get
            {
                return _hostBooking.Show.HasTalkBack;
            }
        }

        public double ExtendBasePrice(double basePrice)
        {
            var result = basePrice;
            result += _extras.PremiumFee;
            return result;
        }

        public bool HasDinner
        {
            get
            {
                return _hostBooking.Show.HasDinner && !_hostBooking.IsPeakDay;
            }
        }
    }
}
