namespace PreserveWholeObject.Original
{
    public class Tests
    {
        [Fact]
        public void TestTemperatureValidator()
        {
            //arrange
            var plan = new Plan()
            {
                LowRange = 15,
                HighRange = 25
            };
            var sut = new TemperatureValidator(plan);

            //act and assert
            Assert.Throws(typeof(Exception), () => sut.ValidateRoomTemperature(new Room(14)));
            Assert.Throws(typeof(Exception), () => sut.ValidateRoomTemperature(new Room(26)));
            sut.ValidateRoomTemperature(new Room(16));
        }
    }
}