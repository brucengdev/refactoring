/**
 * Step 3: modify callers to use the new structure
 **/

namespace IntroduceParameterObject.Step3
{
    public class Station
    {
        public float Temperature { get; set; }
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
            return stations.Where(s => {
                var tempRange = new Range(minTemp, maxTemp);
                return IsTempOutsideRange(s, minTemp, maxTemp, tempRange);
            }).ToList();
        }
    }
}
