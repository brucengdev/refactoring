/**
 * Step 4: use one element in the new structure (maxTemp)
 * Switch from using maxTemp parameter to use tempRange.Max
 * Remove the parameter
 * Test
 **/

namespace IntroduceParameterObject.Step5
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
    }

    public class Program
    {
        private bool IsTempOutsideRange(Station station, 
            Range tempRange)
        {
            return station.Temperature < tempRange.Min || station.Temperature > tempRange.Max;
        }
        public IEnumerable<Station> GetStationsOutsideRange(Station[] stations, float minTemp, float maxTemp)
        {
            return stations.Where(s => {
                var tempRange = new Range(minTemp, maxTemp);
                return IsTempOutsideRange(s, tempRange);
            }).ToList();
        }
    }
}
