namespace ConsolidateConditionalExpression
{
    internal class Refactored : ICalculateDisabilityAmount
    {
        public float CalculateDisabilityAmount(Employee anEmployee)
        {
            if(IsNotEligibleForDisabilityAmount(anEmployee)) { 
                return 0; 
            }

            return 125;
        }

        private bool IsNotEligibleForDisabilityAmount(Employee anEmployee)
        {
            return anEmployee.Seniority < 2
                || anEmployee.MonthsDisabled > 12
                || anEmployee.IsPartTime;
        }
    }
}
