namespace DecomposeConditional
{
    internal class RefactoredCalculator : IChargeCalculator
    {
        private Plan _plan { get; set; }
        public RefactoredCalculator(Plan plan)
        {
            _plan = plan;
        }
        public float CalculateCharge(int quantity, DateTime date)
        {
            return IsSummer(date)? SummerCharge(quantity): RegularCharge(quantity);
        }

        private bool IsSummer(DateTime date) {
            return date >= _plan.SummerStart && date <= _plan.SummerEnd;
        }

        private float SummerCharge(int quantity)
        {
            return quantity* _plan.SummerRate;
        }

        private float RegularCharge(int quantity)
        {
            return quantity* _plan.RegularRate + _plan.RegularServiceCharge;
        }
    }
}
