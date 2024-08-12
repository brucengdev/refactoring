/**
 * Step 4: use one element in the new structure (minTemp)
 * Switch from using minTemp parameter to use tempRange.Min
 * Remove the parameter
 * Test
 **/

namespace IntroduceParameterObject.Step4
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
            float maxTemp, 
            Range tempRange)
        {
            return station.Temperature < tempRange.Min || station.Temperature > maxTemp;
        }
        public IEnumerable<Station> GetStationsOutsideRange(Station[] stations, float minTemp, float maxTemp)
        {
            return stations.Where(s => {
                var tempRange = new Range(minTemp, maxTemp);
                return IsTempOutsideRange(s, maxTemp, tempRange);
            }).ToList();
        }
    }
}
