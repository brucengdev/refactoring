namespace CombinedFunctionsIntoTransform.Refactored
{
    public class TeaConsumption
    {
        public string Customer;
        public int Quantity;
        public int Month;
        public int Year;
    }

    public class EnrichedTeaConsumption: TeaConsumption
    {
        public float BaseCharge;
        public float TaxableAmount;
        
        public static EnrichedTeaConsumption Clone(TeaConsumption rawData)
        {
            //do a deep clone of the raw record
            return new EnrichedTeaConsumption
            {
                Customer = rawData.Customer,
                Quantity = rawData.Quantity,
                Month = rawData.Month,
                Year = rawData.Year
            };
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

        private float GetBaseRate(int month, int year)
        {
            return 4.5f;
        }

        private float TaxThreshold(int year)
        {
            return 1000;//if you consume less than 1000$ of tea, no tax.
        }

        private float CalculateBaseCharge(TeaConsumption rawReading)
        {
            return GetBaseRate(rawReading.Month, rawReading.Year) * rawReading.Quantity;
        }

        private float CalculateTaxableAmount(float baseCharge, int year)
        {
            return Math.Max(0, baseCharge - TaxThreshold(year));
        }

        public EnrichedTeaConsumption Enrich(TeaConsumption rawData)
        {
            var enrichedRecord = EnrichedTeaConsumption.Clone(rawData);
            enrichedRecord.BaseCharge = CalculateBaseCharge(rawData);
            enrichedRecord.TaxableAmount = CalculateTaxableAmount(enrichedRecord.BaseCharge, enrichedRecord.Year);
            return enrichedRecord;
        }
        public void Client1()
        {
            var rawReading = GetRawReading();
            var enriched = Enrich(rawReading);
            //calculations of derived values are consolidated into one function
            //for reuse
            var baseCharge = enriched.BaseCharge;
            //use the base charge for reporting here
        }

        public void Client2()
        {
            var rawReading = GetRawReading();
            var enriched = Enrich(rawReading);
            var taxableAmount = enriched.TaxableAmount;
            //use the taxable amount for reporting here.
        }
    }
}
