namespace CombinedFunctionsIntoTransform.Original
{
    public class TeaConsumption
    {
        public string Customer;
        public int Quantity;
        public int Month;
        public int Year;
    }

    public class Clients
    {
        public Clients()
        {

        }
        private TeaConsumption GetRawReading()
        {
            return new TeaConsumption
            {
                Customer = "Ivan",
                Quantity = 10,
                Month = 5,
                Year = 2017
            };
        }

        private float GetBaseRate(int month, int year)
        {
            return 4.5f;
        }

        private float TaxThreshold(int year)
        {
            return 1000;//if you consume less than 1000$ of tea, no tax.
        }
        public void Client1()
        {
            var rawReading = GetRawReading();
            var baseCharge = GetBaseRate(rawReading.Month, rawReading.Year) * rawReading.Quantity;
            //use the base charge for reporting here
        }

        public void Client2()
        {
            var rawReading = GetRawReading();
            var baseCharge = GetBaseRate(rawReading.Month, rawReading.Year) * rawReading.Quantity;
            var taxableAmount = Math.Max(0 , baseCharge - TaxThreshold(rawReading.Year));
            //use the taxable amount for reporting here.
        }
    }
}
