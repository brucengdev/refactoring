using Shouldly;

namespace ReplaceQueryWithParameter.Refactored
{
    public class Tests
    {
        [Theory]
        //          min max cur tar status
        //selected temp is within range
        [InlineData(20, 30, 22, 25, AirConStatus.Heating)]
        [InlineData(20, 30, 27, 25, AirConStatus.Cooling)]
        [InlineData(20, 30, 25, 25, AirConStatus.Off)]

        //selected temp < min
        [InlineData(20, 30, 19, 19, AirConStatus.Heating)]
        [InlineData(20, 30, 20, 19, AirConStatus.Off)]
        [InlineData(20, 30, 21, 19, AirConStatus.Cooling)]
        [InlineData(20, 30, 21, 20, AirConStatus.Cooling)]
        [InlineData(20, 30, 20, 20, AirConStatus.Off)]

        //selected temp >= max
        [InlineData(20, 30, 30, 32, AirConStatus.Off)]
        [InlineData(20, 30, 29, 32, AirConStatus.Heating)]
        [InlineData(20, 30, 33, 33, AirConStatus.Cooling)]
        [InlineData(20, 30, 30, 30, AirConStatus.Off)]
        public void AirConTest(
            int min,
            int max,
            int currentTemp, 
            int selectedTemp, 
            AirConStatus expected)
        {
            //arrange
            var plan = new HeatingPlan(min,max);
            var sut = new Aircon(plan);

            //act
            Thermostat.SelectedTemp = selectedTemp;
            Thermostat.CurrentTemp = currentTemp;
            sut.Adjust();

            //assert
            sut.Status.ShouldBe(expected);
        }
    }
}