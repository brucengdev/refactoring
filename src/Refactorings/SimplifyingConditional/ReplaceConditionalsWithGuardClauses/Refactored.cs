namespace ReplaceConditionalsWithGuardClauses
{
    internal class Refactored
    {
        public Payment PayAmount(Employee emp)
        {
            if (emp.IsSeparated) { return new Payment { Amount = 0, Reason = "SEP" }; }
            if (emp.IsRetired) { return new Payment { Amount = 0, Reason = "RET" }; }
         
            //some calculation
            return new Payment { Amount = 12 };
        }
    }
}
