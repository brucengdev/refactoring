/**
 * Step 6: Move logic to the new type
 * Remember to test
 **/

namespace IntroduceParameterObject.Step6
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
            Min = min;Max = max;
        }
        public bool Contains(float value)
        {
            return value >= Min && value <= Max;
        }
    }

    public class Program
    {
        public IEnumerable<Station> GetStationsOutsideRange(Station[] stations, float minTemp, float maxTemp)
        {
            return stations.Where(s => {
                var tempRange = new Range(minTemp, maxTemp);
                return !tempRange.Contains(s.Temperature);
            }).ToList();
        }
    }
}
