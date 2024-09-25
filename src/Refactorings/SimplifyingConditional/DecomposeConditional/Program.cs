using DecomposeConditional;
using System.Diagnostics;

var plan = new Plan
{
    RegularRate = 10,
    RegularServiceCharge = 7,
    SummerRate = 5,
    SummerStart = new DateTime(2024, 5, 1),
    SummerEnd = new DateTime(2024, 7, 30)
};

var originalCalculator = new OriginalCalculator(plan);

var refactoredCalculator = new RefactoredCalculator(plan);

var originalCharge = originalCalculator.CalculateCharge(4, new DateTime(2024, 6, 2));
var refactoredCharge = refactoredCalculator.CalculateCharge(4, new DateTime(2024, 6, 2));
Debug.Assert(originalCharge == refactoredCharge);


originalCharge = originalCalculator.CalculateCharge(7, new DateTime(2024, 8, 2));
refactoredCharge = refactoredCalculator.CalculateCharge(7, new DateTime(2024, 8, 2));
Debug.Assert(originalCharge == refactoredCharge);
