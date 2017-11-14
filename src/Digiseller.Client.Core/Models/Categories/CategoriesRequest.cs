using System.Xml.Serialization;
using Digiseller.Client.Core.Models.Categories.Request;

namespace Digiseller.Client.Core.Models.Categories
{
    [XmlRoot(ElementName = "digiseller.request")]
    public class CategoriesRequest
    {
        public CategoriesRequest() { }
        public CategoriesRequest(uint sellerId, int categoryId, string languageCode)
        {
            Seller = new Seller(sellerId);
            Category = new Category(categoryId);
            Lang = languageCode;
        }

        [XmlElement(ElementName = "seller")]
        public Seller Seller { get; set; }
        [XmlElement(ElementName = "category")]
        public Category Category { get; set; }
        [XmlElement(ElementName = "lang")]
        public string Lang { get; set; }
    }
}