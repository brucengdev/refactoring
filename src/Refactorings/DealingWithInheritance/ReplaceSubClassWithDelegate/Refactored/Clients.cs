namespace ReplaceSubClassWithDelegate.Refactored
{
    internal class Clients
    {
        public string GetTicketInfos(Show show, DateTime date, bool isPeak)
        {
            var booking = new Booking(show, date, isPeak);
            return $"Booking\n" +
                $"Talkback: {booking.HasTalkback}\n" +
                $"Peak day?: {booking.IsPeakDay}\n" +
                $"Base price: {booking.BasePrice}";
        }

        public string GetTicketInfos(
            Show show, 
            DateTime date, 
            bool isPeak, 
            Extras extras)
        {
            var booking = new PremiumBooking(show, date, isPeak, extras);
            return $"Premium booking\n" +
                $"Talkback: {booking.HasTalkback}\n" +
                $"Dinner: {booking.HasDinner}\n" +
                $"Peak day?: {booking.IsPeakDay}\n" +
                $"Base price: {booking.BasePrice}";
        }
    }
}
