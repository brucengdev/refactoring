using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateQueryFromModifier.Original
{
    internal interface IAlarm
    {
        void Start();
    }
    internal class Alarm: IAlarm
    {
        public void Start() {
            //trigger physical alarm to start    
        }
    }
}
