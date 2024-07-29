namespace Loops.Original
{
    /**
     * Loops are old, but they tend to be not as expressive and easy
     * to understand compared to modern constructs like lambdas.
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
            //the best boxer is the one with most wins in a weight class.
            var result = new Dictionary<WeightClass, int>();
            var mostWins = new Dictionary<WeightClass, int>();

            for(int i = 0; i < boxers.Length; i++)
            {
                var boxer = boxers[i];
                var matchesWon = 0;
                for(int j = 0; j < boxer.Matches.Length; j++)
                {
                    var match = boxer.Matches[j];
                    if(match.Win)
                    {
                        matchesWon++;
                    }
                }

                if (mostWins.GetValueOrDefault(boxer.WeightClass, 0) < matchesWon)
                {
                    mostWins[boxer.WeightClass] = matchesWon;
                    result[boxer.WeightClass] = i;
                }
            }

            return result;
        }
    }
}
