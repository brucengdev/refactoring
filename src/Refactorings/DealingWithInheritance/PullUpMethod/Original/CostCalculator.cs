namespace PullUpMethod.Original
{
    internal class CostCalculator
    {
        public float GetAnnualCost(Employee emp)
        {
            return emp.GetAnnualCost();
        }

        public float GetAnnualCost(Department dept)
        {
            return dept.GetTotalAnnualCost();
        }
    }
}
