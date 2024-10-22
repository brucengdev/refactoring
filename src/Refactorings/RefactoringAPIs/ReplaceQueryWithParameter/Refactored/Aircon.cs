namespace ReplaceQueryWithParameter.Refactored
{
    public enum AirConStatus
    {
        Off,
        Heating,
        Cooling
    }
    internal class Aircon
    {
        private HeatingPlan _plan { get;set; }
        private AirConStatus _status;
        public AirConStatus Status {
            get { return _status; }
        }

        public Aircon(HeatingPlan plan)
        {
            _plan = plan;
        }

        public void Adjust()
        {
            if(_plan.TargetTemp(Thermostat.SelectedTemp) > Thermostat.CurrentTemp)
            {
                SetToHeat();
            } else if(_plan.TargetTemp(Thermostat.SelectedTemp) < Thermostat.CurrentTemp)
            {
                SetToCool();
            } else
            {
                SetOff();
            }
        }

        private void SetToHeat() {
            _status = AirConStatus.Heating;
        }

        private void SetToCool()
        {
            _status = AirConStatus.Cooling;
        }

        private void SetOff()
        {
            _status = AirConStatus.Off;
        }
    }
}
