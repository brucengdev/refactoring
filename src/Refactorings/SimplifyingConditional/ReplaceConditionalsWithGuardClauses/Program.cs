using ReplaceConditionalsWithGuardClauses;
using System.Diagnostics;

var employee = new Employee
{
    IsSeparated = false,
    IsRetired = true
};

var originalPayment = (new Original()).PayAmount(employee);

var refactoredPayment = (new Refactored()).PayAmount(employee);

Debug.Assert(originalPayment.Amount == refactoredPayment.Amount);
Debug.Assert(originalPayment.Reason == refactoredPayment.Reason);
