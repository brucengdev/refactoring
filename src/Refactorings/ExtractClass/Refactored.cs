namespace ExtractClass.Refactored
{
    internal class TelephoneNumber
    {
        public string AreaCode { get;set; }
        public string Number { get;set; }

        public string PhoneNumber
        {
            get
            {
                return $"{AreaCode}{Number}";
            }
        }
    }
    public class Person
    {
        private TelephoneNumber _telephoneNumber = new();

        public string Name { get;set; }
        public string TelephoneNumber { 
            get{
                return _telephoneNumber.PhoneNumber;
            } 
        }

        public string OfficeAreaCode { 
            get{
                return _telephoneNumber.AreaCode;
            } 
            set{
                _telephoneNumber.AreaCode = value;
            } 
        }

        public string OfficeNumber { 
            get{
                return _telephoneNumber.Number;
            }
            set
            {
                _telephoneNumber.Number = value;
            }
        }
    }
}
