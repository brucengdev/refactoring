using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceQueryWithParameter.Original
{
    internal class HeatingPlan
    {
        private int _max { get; set; }
        private int _min { get; set; }

        public HeatingPlan(int min, int max)
        {
            _max = max;
            _min = min;
        }

        public int TargetTemp()
        {
            if(Thermostat.SelectedTemp > _max)
            {
                return _max;
            }
            if(Thermostat.SelectedTemp < _min)
            {
                return _min;
            }

            return Thermostat.SelectedTemp;
        }
    }
}
