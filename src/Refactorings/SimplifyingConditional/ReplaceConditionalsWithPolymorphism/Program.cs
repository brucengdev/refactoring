using System.Diagnostics;

namespace ReplaceConditionalsWithPolymorphism;

public class Voyage
{
    public string Zone { get; set; } = "";
    public int Length { get; set; }
}

public class PastVoyage
{
    public string Zone { get; set; }
    public int Profit { get; set; }
}

public class History
{
    public List<PastVoyage> Voyages { get; set; } = [];
}

internal enum Rating
{
    A,
    B
}

internal interface IRatingCalculator
{
    Rating GetRating(Voyage voyage, History history);
}

internal class Program
{
    private static void Main(string[] args)
    {
        var original = new Original();
        var refactored = new Refactored();

        var voyage = new Voyage { Zone = "west-indies", Length = 10 };
        var history = new History
        {
            Voyages =
            [
                new() { Zone = "east-indies", Profit = 5 },
                new() { Zone = "west-indies", Profit = 15 },
                new() { Zone = "china", Profit = -2 },
                new() { Zone = "west-africa", Profit = 7 },
            ]
        };

        Debug.Assert(original.GetRating(voyage, history) == refactored.GetRating(voyage, history));
    }
}