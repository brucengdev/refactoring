using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace SplitVariable
{
    internal class Refactored : IDistanceCalculator
    {
        public double DistanceTravelled(Scenario scenario, double time)
        {
            var primaryAcceleration = scenario.PrimaryForce / scenario.Mass;
            var primaryTime = Math.Min(time, scenario.Delay);
            var result = 0.5 * primaryAcceleration * primaryTime * primaryTime;

            var secondaryTime = time - scenario.Delay;
            if (secondaryTime > 0)
            {
                var initialVelocity = primaryAcceleration * scenario.Delay;
                var secondaryAcceleration = (scenario.PrimaryForce + scenario.SecondaryForce) / scenario.Mass;
                result += initialVelocity * secondaryTime + 0.5 * secondaryAcceleration * secondaryTime * secondaryTime;
            }

            return result;
        }
    }
}
