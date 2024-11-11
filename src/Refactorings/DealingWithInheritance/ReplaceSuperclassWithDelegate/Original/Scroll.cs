
namespace ReplaceSuperclassWithDelegate.Original
{
    internal class Scroll: CatalogItem
    {
        private DateTime _lastCleaned;
        public Scroll(int id, string title, string[] tags, DateTime dateLastCleaned)
            : base(id, title, tags)
        {
            _lastCleaned = dateLastCleaned;
        }

        public bool NeedsCleaning(DateTime target)
        {
            var threshold = HasTag("revered")? 700: 1500;
            return (target - _lastCleaned).TotalDays >= threshold;
        }
    }
}
