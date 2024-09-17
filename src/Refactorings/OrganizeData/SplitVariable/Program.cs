using SplitVariable;

public class Program
{
    public class Scenario
    {
        public double Mass;
        public double Delay;
        public double PrimaryForce;
        public double SecondaryForce;
    }

    public interface IDistanceCalculator {
        double DistanceTravelled(Scenario scenario, double time);
    }

    public static void Main(string[] args)
    {
        var scenario = new Scenario { Delay = 1000, Mass = 2, 
            PrimaryForce = 500, SecondaryForce = 300 };

        Console.WriteLine("Original calculator");
        Console.WriteLine("Distance: {0}", (new Original()).DistanceTravelled(scenario, 3000));

        Console.WriteLine("\nRefactored calculator");
        Console.WriteLine("Distance: {0}", (new Refactored()).DistanceTravelled(scenario, 3000));
    }
}