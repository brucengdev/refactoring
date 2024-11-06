namespace ReplaceSubClassWithDelegate.Refactored
{
    internal class Clients
    {
        private Booking CreateBooking(Show show, DateTime date, bool isPeak)
        {
            return new Booking(show, date, isPeak);
        }

        private Booking CreateBooking(Show show, DateTime date, bool isPeak, Extras extras)
        {
            var result = new Booking(show, date, isPeak);
            result.BePremium(extras);
            return result;
        }

        public string GetTicketInfos(Show show, DateTime date, bool isPeak)
        {
            var booking = CreateBooking(show, date, isPeak);
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
            var booking = CreateBooking(show, date, isPeak, extras);
            return $"Premium booking\n" +
                $"Talkback: {booking.HasTalkback}\n" +
                $"Dinner: {booking.HasDinner}\n" +
                $"Peak day?: {booking.IsPeakDay}\n" +
                $"Base price: {booking.BasePrice}";
        }
    }
}
