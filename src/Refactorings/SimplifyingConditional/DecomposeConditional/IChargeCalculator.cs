using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecomposeConditional
{
    internal interface IChargeCalculator
    {
        float CalculateCharge(int quantity, DateTime date);
    }
}
