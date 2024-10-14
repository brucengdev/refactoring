namespace ParameterizeFunction.Original
{
    internal class ChargeCalculator
    {
        public double BaseChage(int usage)
        {
            if(usage < 0) { return 0; }

            var amount = bottomBand(usage) * 0.03
                + middleBand(usage) * 0.05
                + topBand(usage) * 0.07;
            return amount;
        }

        private int bottomBand(int usage) {
            return Math.Min(usage, 100);
        }

        private int middleBand(int usage) {
            return usage > 100? Math.Min(usage, 200) - 100: 0;
        }

        private int topBand(int usage) {
            return usage > 200? usage - 200: 0;
        }
    }
}
