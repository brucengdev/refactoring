namespace CombinedFunctionsIntoClass.Refactored
{
    /**
     * It's typically preferable to use immutable data
     * When that is not possible, encapsulate functions into a class
     * so modifications to the data is centralized.
     **/ 
    public class TeaConsumption
    {
        public string Customer;
        public int Quantity;
        public int Month;
        public int Year;

        private float GetBaseRate(int month, int year)
        {
            return 4.5f;
        }

        private float TaxThreshold(int year)
        {
            return 1000;//if you consume less than 1000$ of tea, no tax.
        }

        public float BaseCharge {
            get
            {
                return GetBaseRate(Month, Year) * Quantity;
            }
        }

        public float TaxableAmount
        {
            get
            {
                return Math.Max(0, BaseCharge - TaxThreshold(Year));
            }
        }
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

        public void Client1()
        {
            var reading = GetRawReading();
            var baseCharge = reading.BaseCharge;
            //use the base charge for reporting here
        }

        public void Client2()
        {
            var reading = GetRawReading();
            var baseCharge = reading.BaseCharge;
            var taxableAmount = reading.TaxableAmount;
            //use the taxable amount for reporting here.
        }
    }
}
