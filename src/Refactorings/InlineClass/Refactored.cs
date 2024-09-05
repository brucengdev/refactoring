namespace InlineClass.Original
{
    public class TrackingInformation
    {
        public string ShippingCompany { get;set; }
        public string TrackingNumber { get;set; }

        public override string ToString()
        {
            return $"{ShippingCompany}:{TrackingNumber}";
        }
    }
    public class Shipment
    {
        private TrackingInformation _trackingInformation = new();
        public string GetTrackingInfo()
        {
            return _trackingInformation.ToString();
        }

        public TrackingInformation GetTrackingInformation() { return _trackingInformation; }

        public void SetTrackingInformation(TrackingInformation aTrackingInformation)
        {
            _trackingInformation = aTrackingInformation;
        }
    }

    public class User
    {
        public void CreateShipment()
        {
            var shipment = new Shipment();
            shipment.GetTrackingInformation().ShippingCompany = "AVendor";
        }
    }
}
