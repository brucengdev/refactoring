using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace SplitVariable
{
    /**
     * In this example, acc variable is used for two purposes
     * The first is the initial acceleration created by the primary force
     * The second use is the acceleration created by both the primary and secondary forces later
     * We should split it into two variables.
     **/ 
    internal class Original : IDistanceCalculator
    {
        public double DistanceTravelled(Scenario scenario, double time)
        {
            var acc = scenario.PrimaryForce / scenario.Mass;
            var primaryTime = Math.Min(time, scenario.Delay);
            var result = 0.5 * acc * primaryTime * primaryTime;

            var secondaryTime = time - scenario.Delay;
            if(secondaryTime > 0)
            {
                var initialVelocity = acc * scenario.Delay;
                acc = (scenario.PrimaryForce + scenario.SecondaryForce) / scenario.Mass;
                result += initialVelocity * secondaryTime + 0.5 * acc * secondaryTime * secondaryTime;
            }

            return result;
        }
    }
}
