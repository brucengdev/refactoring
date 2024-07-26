namespace PrimitiveObsession.Refactored
{
    /**
     * An example of primitive obsession.
     * In this refactored example, instead of using float for money, we
     * create a dedicated type Money that handles everything related to money.
     * This way all processing needed for this type is encapsulated in one place.
     * And the users of the type can just use it for Money without having to take 
     * care of currency related processing and conversions.
     * 
     * The displaying of money is also consolidated in the class.
     **/
    public enum Currency
    {
        USD,
        SGD,
        VND
    }

    public class Money
    {
        private static Dictionary<Currency, float> exchangeRates;
        private readonly Currency _currency;
        private readonly float _amount;

        public Money(Currency currency, float amount)
        {
            _currency = currency;
            _amount = amount;
        }

        public float Amount {  get {  return _amount; } }
        public Currency Currency { get {  return _currency; } }

        public Money Add(Money other, Currency targetCurrency)
        {
            var uniAmount = Amount * exchangeRates[Currency] + other.Amount * exchangeRates[other.Currency];
            return new Money(targetCurrency, uniAmount / exchangeRates[targetCurrency]);
        }

        //centralize display of money
        public override string ToString()
        {
            return string.Format("{0:F2}{1}", Amount, Currency);
        }
    }

    public class PrimitiveObsessionExample
    {
        
        public Money getTotalMoney(Money[] payments, Currency targetCurrency)
        {
            var total = new Money(targetCurrency, 0);
            foreach(var payment in payments)
            {
                total = total.Add(payment, targetCurrency);
            }
            return total;
        }
    }
}
