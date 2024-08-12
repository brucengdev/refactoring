/**
 * Step 1: introduce the new structure
 * 
 * Add a new structure, then run tests. Probably no failures.
 **/

namespace IntroduceParameterObject.Step1
{
    public class Station
    {
        public float Temperature { get;set; }
    }

    public class Range
    {
        private float Min, Max;
        public Range(float min, float max)
        {
            Min = min; Max = max;
        }
    }

    public class Program
    {
        private bool IsTempOutsideRange(Station station, float minTemp, float maxTemp)
        {
            return station.Temperature < minTemp || station.Temperature > maxTemp;
        }
        public IEnumerable<Station> GetStationsOutsideRange(Station[] stations, float minTemp, float maxTemp)
        {
            return stations.Where(s => IsTempOutsideRange(s, minTemp, maxTemp)).ToList();
        }
    }
}
