
namespace PreserveWholeObject.Refactored
{
    internal class TemperatureValidator
    {
        private Plan _aPlan { get; set; }
        public TemperatureValidator(Plan aPlan)
        {
            _aPlan = aPlan;
        }
        public void ValidateRoomTemperature(Room aRoom)
        {
            var lowRange = _aPlan.LowRange;
            var highRange = _aPlan.HighRange;

            if(IsOutOfRange(aRoom.Temp, _aPlan))
            {
                throw new Exception("Room temperature out of range");
            }
        }

        private bool IsOutOfRange(int temp, Plan plan)
        {
            return temp < plan.LowRange || temp > plan.HighRange;
        }
    }
}
