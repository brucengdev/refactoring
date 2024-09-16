namespace ReplaceLoopWithPipeline.Original
{
    public class Refactored { 

        public static Record[] AccquireData(string data, string country)
        {
            var lines = data.Split('\n');

            return lines
                .Select(line => line.Trim())
                .Where(line => !string.IsNullOrEmpty(line))
                .Skip(1)
                .Select(line => line.Split(','))
                .Where(values => values[1] == country)
                .Select(values => new Record()
                {
                    Office = values[0],
                    Country = values[1],
                    Telephone = values[2]
                })
                .ToArray()
                ;
        }
    }
}
