/**
 * Step 2: Use Change Function Declaration to add a new parameter that uses the new structure
 * Test
 **/

namespace IntroduceParameterObject.Step2
{
    public class Station
    {
        public float Temperature { get;set; }
    }

    public class Range
    {
        public float Min, Max;
        public Range(float min, float max)
        {
            Min = min; Max = max;
        }
    }

    public class Program
    {
        private bool IsTempOutsideRange(Station station, 
            float minTemp, 
            float maxTemp,
            Range tempRange)
        {
            return station.Temperature < minTemp || station.Temperature > maxTemp;
        }
        public IEnumerable<Station> GetStationsOutsideRange(Station[] stations, float minTemp, float maxTemp)
        {
            return stations.Where(s => IsTempOutsideRange(s, minTemp, maxTemp, null)).ToList();
        }
    }
}
