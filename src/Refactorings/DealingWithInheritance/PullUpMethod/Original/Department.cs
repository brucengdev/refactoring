using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpMethod.Original
{
    internal class Department: Party
    {
        public float MonthlyCost { get; set; }

        public float GetTotalAnnualCost()
        {
            return this.MonthlyCost * 12;
        }
    }
}
