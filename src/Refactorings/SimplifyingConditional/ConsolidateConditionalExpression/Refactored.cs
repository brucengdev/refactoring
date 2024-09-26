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

        public float CalculatePayRate(Employee anEmployee)
        {
            if (IsEligibleForFullPayRate(anEmployee))
            {
                return 1;
            }
            return 0.5f;
        }

        private bool IsEligibleForFullPayRate(Employee anEmployee) {
            return anEmployee.OnVacation && anEmployee.Seniority > 10;
        }
    }
}
