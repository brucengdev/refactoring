using Shouldly;

namespace ReplaceSubClassWithDelegate.Original
{
    public class Tests
    {
        [Fact]
        public async Task TestBooking()
        {
            var sut = new Clients();

            sut.GetTicketInfos(new() {HasTalkBack = true, Price = 10 }, DateTime.Now, true)
                .ShouldBe(
                $"Booking\n" +
                $"Talkback: True\n" +
                $"Peak day?: True\n" +
                $"Base price: 12");

            sut.GetTicketInfos(new() { HasTalkBack = false, Price = 20 }, DateTime.Now, false)
                .ShouldBe(
                $"Booking\n" +
                $"Talkback: False\n" +
                $"Peak day?: False\n" +
                $"Base price: 20");
        }

        [Fact]
        public async Task TestPremiumBooking()
        {
            var sut = new Clients();

            sut.GetTicketInfos(new() { HasTalkBack = true, Price = 10 }, 
                DateTime.Now, true, new() { PremiumFee = 4 })
                .ShouldBe(
                $"Premium booking\n" +
                $"Talkback: True\n" +
                $"Dinner: False\n" +
                $"Peak day?: True\n" +
                $"Base price: 16");

            sut.GetTicketInfos(new() { HasTalkBack = false, Price = 20 }, 
                DateTime.Now, false, new() { PremiumFee = 10 })
                .ShouldBe(
                $"Premium booking\n" +
                $"Talkback: False\n" +
                $"Dinner: False\n" +
                $"Peak day?: False\n" +
                $"Base price: 30");
        }
    }
}