namespace Loops.Refactored
{
    /**
     * In this example, we replace loops with more modern constructs
     * like lambdas.
     **/

    public enum WeightClass
    {
        LIGHTWEIGHT,
        MIDDLEWEIGHT,
        HEAVYWEIGHT
    }

    public class Match
    {
        public bool Win;
    }

    public class Boxer
    {
        public WeightClass WeightClass;
        public Match[] Matches;
    }

    public class LoopsExample
    {
        public Dictionary<WeightClass, int> CalculateBestBoxers(Boxer[] boxers)
        {
            return boxers.Select((boxer, boxerKey) 
                => new {
                    WeightClass = boxer.WeightClass,
                    MatchesWon = boxer.Matches.Sum(m => m.Win?1:0),
                    BoxerId = boxerKey
                }).GroupBy(b => b.WeightClass)
                .Select(weightGroup => new KeyValuePair<WeightClass, int>(weightGroup.Key, 
                weightGroup.Max(boxer => boxer.MatchesWon)))
                .ToDictionary();
        }
    }
}
