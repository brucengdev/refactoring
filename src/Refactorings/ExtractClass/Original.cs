namespace ExtractClass.Original
{
    public class Person
    {
        public string Name { get;set; }
        public string TelephoneNumber { get{
                return $"{OfficeAreaCode}{OfficeNumber}";
            } }

        public string OfficeAreaCode { get; set; }

        public string OfficeNumber { get;set; }
    }
}
