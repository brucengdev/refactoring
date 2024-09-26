namespace ConsolidateConditionalExpression
{
    internal class Employee
    {
        public int Seniority { get; set; }
        public int MonthsDisabled { get; set; }
        public bool IsPartTime { get; set; }
        public bool OnVacation { get; set; }
    }
    internal interface ICalculateDisabilityAmount
    {
        float CalculateDisabilityAmount(Employee anEmployee);

        float CalculatePayRate(Employee anEmployee);
    }
}
