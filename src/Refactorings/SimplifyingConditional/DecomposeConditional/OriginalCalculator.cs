namespace DecomposeConditional
{
    internal class OriginalCalculator : IChargeCalculator
    {
        private Plan _plan { get; set; }
        public OriginalCalculator(Plan plan)
        {
            _plan = plan;
        }
        public float CalculateCharge(int quantity, DateTime date)
        {
            if(date >= _plan.SummerStart && date <= _plan.SummerEnd)
            {
                return quantity * _plan.SummerRate;
            }
            else
            {
                return quantity * _plan.RegularRate + _plan.RegularServiceCharge;
            }
        }
    }
}
