namespace SeparateQueryFromModifier.Original
{
    internal class MiscreantAlerter
    {
        private readonly IAlarm _alarm;
        public MiscreantAlerter(IAlarm alarm)
        {
            _alarm = alarm;
        }
        public string AlertForMiscreant(List<string> people)
        {
            foreach(var person in people)
            {
                if(person == "Don")
                {
                    SetOffAlarms();
                    return "Don";
                }
                if(person == "John")
                {
                    SetOffAlarms();
                    return "John";
                }
            }
            return "";
        }

        private void SetOffAlarms()
        {
            _alarm.Start();
        }
    }
}
