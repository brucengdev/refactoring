using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceQueryWithParameter.Refactored
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

        public int TargetTemp(int selectedTemp)
        {
            if (selectedTemp > _max)
            {
                return _max;
            }
            if (selectedTemp < _min)
            {
                return _min;
            }

            return selectedTemp;
        }
    }
}
