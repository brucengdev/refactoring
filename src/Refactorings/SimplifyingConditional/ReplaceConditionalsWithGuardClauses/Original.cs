namespace ReplaceConditionalsWithGuardClauses
{
    internal class Original
    {
        public Payment PayAmount(Employee emp)
        {
            if (emp.IsSeparated)
            {
                return new Payment { Amount = 0, Reason = "SEP" };
            }
            else
                if (emp.IsRetired)
                {
                    return new Payment { Amount = 0, Reason = "RET" };
                }
                else
                {
                    //some calculation
                    return new Payment { Amount = 12 };
                }
        }
    }
}
