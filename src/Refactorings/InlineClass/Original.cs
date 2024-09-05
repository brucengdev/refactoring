namespace InlineClass.Refactored
{
    public class Shipment
    {
        private string _shippingCompany;
        private string _trackingNumber;
        public string GetTrackingInfo()
        {
            return $"{_shippingCompany}:{_trackingNumber}";
        }

        public string GetShippingCompany()
        {
            return _shippingCompany;
        }
        public void SetShippingCompany(string company)
        {
            _shippingCompany = company;
        }

        public string GetTrackingNumber()
        {
            return _trackingNumber;
        }
        public void SetTrackingNumber(string trackingNumber)
        {
            _trackingNumber = trackingNumber;
        }
    }

    public class User
    {
        public void CreateShipment()
        {
            var shipment = new Shipment();
            shipment.SetShippingCompany("AVendor");
        }
    }
}
