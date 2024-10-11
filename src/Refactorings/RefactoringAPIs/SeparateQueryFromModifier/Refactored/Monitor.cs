using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateQueryFromModifier.Refactor
{
    //monitor the people in the room and fire an alarm
    //when a miscreant is found
    internal class Monitor
    {
        private readonly MiscreantAlerter _alerter;
        private readonly IMessenger _messenger;

        public Monitor(IAlarm alarm, IMessenger messenger)
        {
            _alerter = new MiscreantAlerter(alarm);
            _messenger = messenger;
        }
        public void PeopleChanged(List<string> currentPeople)
        {
            var miscreant = _alerter.AlertForMiscreant(currentPeople);
            if (miscreant != "")
            {
                _messenger.SendMessage("Miscreant " + miscreant + " found!");
            }
        }
    }
}
