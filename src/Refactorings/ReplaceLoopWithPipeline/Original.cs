namespace ReplaceLoopWithPipeline.Original
{
    public class Original { 

        public static Record[] AccquireData(string data, string country)
        {
            var lines = data.Split('\n');
            var firstLine = true;

            var results = new List<Record>();

            foreach(var line in lines)
            {
                var trimmed = line.Trim();
                if (string.IsNullOrEmpty(trimmed)) { continue; }

                if(firstLine)
                {
                    firstLine = false;
                    continue;
                }

                var values = trimmed.Split(',');

                if (values[1] == country)
                {
                    var record = new Record()
                    {
                        Office = values[0],
                        Country = values[1],
                        Telephone = values[2]
                    };
                    results.Add(record);
                }
            }

            return results.ToArray();
        }
    }
}
