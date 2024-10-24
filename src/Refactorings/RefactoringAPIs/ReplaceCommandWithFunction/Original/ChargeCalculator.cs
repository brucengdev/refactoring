using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceCommandWithFunction.Original
{
    internal class ChargeCalculator
    {
        private Customer _customer { get; set; }
        private Provider _provider { get; set; }

        private int _usage { get; set; }
        public ChargeCalculator(Customer customer, int usage, Provider provider)
        {
            _customer = customer;
            _provider = provider;
            _usage = usage;
        }

        public float BaseCharge
        {
            get
            {
                return _customer.BaseRate * _usage;
            }
        }

        public float Charge
        {
            get
            {
                return BaseCharge + _provider.ConnectionCharge;
            }
        }
    }
}
