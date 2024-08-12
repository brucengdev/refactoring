namespace IntroduceParameterObject.Original
{
    public class Station
    {
        public float Temperature { get;set; }
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
