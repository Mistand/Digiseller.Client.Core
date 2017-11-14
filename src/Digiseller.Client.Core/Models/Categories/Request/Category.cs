using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.Categories.Request
{
    [XmlRoot(ElementName = "category")]
    public class Category
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        public Category() { }
        public Category(int categoryId)
        {
            Id = categoryId;
        }
    }
}