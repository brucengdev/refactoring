using ConsolidateConditionalExpression;
using System.Diagnostics;

var employee1 = new Employee
{
    IsPartTime = true,
    MonthsDisabled = 6,
    Seniority = 3,
    OnVacation = true
};

var employee2 = new Employee
{
    IsPartTime = false,
    MonthsDisabled = 7,
    Seniority = 12,
    OnVacation = false
};

var original = new Original();
var refactored = new Refactored();

Debug.Assert(original.CalculateDisabilityAmount(employee1) == refactored.CalculateDisabilityAmount(employee1));

Debug.Assert(original.CalculateDisabilityAmount(employee2) == refactored.CalculateDisabilityAmount(employee2));

Debug.Assert(original.CalculatePayRate(employee1) == refactored.CalculatePayRate(employee1));

Debug.Assert(original.CalculatePayRate(employee2) == refactored.CalculatePayRate(employee2));