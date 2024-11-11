
namespace ReplaceSuperclassWithDelegate.Original
{
    internal class CatalogItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        protected string[] Tags { get; set; }

        public CatalogItem(int id, string title, string[] tags)
        {
            ID = id;
            Title = title;
            Tags = tags;
        }

        public bool HasTag(string tag) => Tags.Contains(tag);
    }
}
