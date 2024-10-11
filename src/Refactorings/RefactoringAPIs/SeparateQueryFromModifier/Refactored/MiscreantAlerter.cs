namespace SeparateQueryFromModifier.Refactor
{
    internal class MiscreantAlerter
    {
        private readonly IAlarm _alarm;
        public MiscreantAlerter(IAlarm alarm)
        {
            _alarm = alarm;
        }
        public string GetMiscreant(List<string> people)
        {
            foreach (var person in people)
            {
                if (person == "Don")
                {
                    return "Don";
                }
                if (person == "John")
                {
                    return "John";
                }
            }
            return "";
        }

        public void AlertForMiscreant(List<string> people)
        {
            if(GetMiscreant(people) != "")
            {
                SetOffAlarms();
            }
        }

        private void SetOffAlarms()
        {
            _alarm.Start();
        }
    }
}
