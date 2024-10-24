using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceCommandWithFunction.Original
{
    internal class Program
    {
        public static void main(string[] args)
        {
            var customer = new Customer();
            var usage = 250;
            var provider = new Provider();

            var monthCharge = new ChargeCalculator(customer, usage, provider).Charge;
        }
    }
}
