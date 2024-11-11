
namespace ReplaceSuperclassWithDelegate.Refactored
{
    internal class Scroll
    {
        private DateTime _lastCleaned;
        private CatalogItem _catalogItem;
        public Scroll(int id, string title, string[] tags, DateTime dateLastCleaned)
        {
            _lastCleaned = dateLastCleaned;
            _catalogItem = new CatalogItem(id, title, tags);
        }

        public bool HasTag(string tag) => _catalogItem.HasTag(tag);
        public int ID => _catalogItem.ID;
        public string Title => _catalogItem.Title;

        public bool NeedsCleaning(DateTime target)
        {
            var threshold = HasTag("revered")? 700: 1500;
            return (target - _lastCleaned).TotalDays >= threshold;
        }
    }
}
