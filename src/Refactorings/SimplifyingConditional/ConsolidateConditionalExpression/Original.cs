namespace ConsolidateConditionalExpression
{
    internal class Original : ICalculateDisabilityAmount
    {
        public float CalculateDisabilityAmount(Employee anEmployee)
        {
            if(anEmployee.Seniority < 2) { return 0; }
            if(anEmployee.MonthsDisabled > 12) { return 0; }
            if(anEmployee.IsPartTime) { return 0; }

            return 125;
        }
    }
}
