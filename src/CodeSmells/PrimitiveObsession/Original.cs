namespace PrimitiveObsession.Original
{
    /**
     * An example of primitive obsession.
     * Instead of creating your own type to handle money, you use primitive like float
     * Because the primitive lacks context and central methods, you have no idea what it does
     * and you need to remember to process the primitive every time it is used.
     * 
     * Other examples: use strings for telephone numbers, multiple numbers for coordinates,...
     * This is not necessary as modern languages have powerful type system that can be used
     * to create domain specific types.
     **/
    public enum Currency
    {
        USD,
        SGD,
        VND
    }
    public class PrimitiveObsessionExample
    {
        
        private Dictionary<Currency, float> exchangeRates;
        public float getTotalMoney((float, Currency)[] payments, 
            Currency targetCurrency)
        {
            float total = 0;
            foreach(var (amount, currency) in payments)
            {
                var convertedAmount = amount * exchangeRates[currency];
                total += convertedAmount;
            }
            return total / exchangeRates[targetCurrency];
        }

        public string PrintMoney(float amount, Currency currency)
        {
            return string.Format("{0:F2}{1}", amount, currency);
        }
    }
}
