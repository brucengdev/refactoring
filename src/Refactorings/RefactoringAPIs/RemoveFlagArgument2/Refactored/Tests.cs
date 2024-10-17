using Moq;
using System.Numerics;

namespace RemoveFlagArgument2.Refactored
{
    public class Tests
    {
        [Fact]
        public void TestRushDelivery()
        {
            //arrange
            var emailSender = new Mock<IEmailSender>();
            var client = new Client(new DeliveryDateCalculator(), emailSender.Object);

            //act
            client.PlaceRushOrders(new()
            {
                new() { Name = "Apples", PlacedOn = new DateTime(2024,12,1), DeliveryState = "MA"},
                new() { Name = "Oranges", PlacedOn = new DateTime(2024,12,1), DeliveryState = "NH"},
                new() { Name = "Peanuts", PlacedOn = new DateTime(2024,12,1), DeliveryState = "AA"},
            });

            //asserts
            var expectedEmailTitle = "Orders with express delivery placed!";
            var expectedEmailContent = 
                "Apples (placed on 12/1/2024 12:00:00 AM), delivery by 12/3/2024 12:00:00 AM\n" 
                + "Oranges (placed on 12/1/2024 12:00:00 AM), delivery by 12/4/2024 12:00:00 AM\n" 
                + "Peanuts (placed on 12/1/2024 12:00:00 AM), delivery by 12/5/2024 12:00:00 AM";
            emailSender.Verify(s => s.SendEmail(expectedEmailTitle, expectedEmailContent), Times.Once);
        }

        [Fact]
        public void TestDelivery()
        {
            //arrange
            var emailSender = new Mock<IEmailSender>();
            var client = new Client(new DeliveryDateCalculator(), emailSender.Object);

            //act
            client.PlaceOrders(new()
            {
                new() { Name = "Apples", PlacedOn = new DateTime(2024,12,1), DeliveryState = "MA"},
                new() { Name = "Oranges", PlacedOn = new DateTime(2024,12,1), DeliveryState = "NH"},
                new() { Name = "Peanuts", PlacedOn = new DateTime(2024,12,1), DeliveryState = "AA"},
            });

            //asserts
            var expectedEmailTitle = "Orders placed!";
            var expectedEmailContent =
                "Apples (placed on 12/1/2024 12:00:00 AM), delivery by 12/5/2024 12:00:00 AM\n"
                + "Oranges (placed on 12/1/2024 12:00:00 AM), delivery by 12/6/2024 12:00:00 AM\n"
                + "Peanuts (placed on 12/1/2024 12:00:00 AM), delivery by 12/7/2024 12:00:00 AM";
            emailSender.Verify(s => s.SendEmail(expectedEmailTitle, expectedEmailContent), Times.Once);
        }
    }
}