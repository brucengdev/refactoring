namespace ParameterizeFunction.Refactored
{
    internal class ChargeCalculator
    {
        public double BaseChage(int usage)
        {
            if(usage < 0) { return 0; }

            var amount = withinBand(usage, 0, 100) * 0.03
                + withinBand(usage, 100, 200) * 0.05
                + withinBand(usage, 200, int.MaxValue) * 0.07;
            return amount;
        }

        private int withinBand(int usage, int bottom, int top) {
            return usage > bottom? Math.Min(usage, top) - bottom: 0;
        }
    }
}
