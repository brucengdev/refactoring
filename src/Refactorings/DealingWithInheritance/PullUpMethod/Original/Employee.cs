﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpMethod.Original
{
    internal class Employee: Party
    {
        public float MonthlyCost { get; set; }

        public float GetAnnualCost()
        {
            return MonthlyCost * 12;
        }
    }
}