using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.ProductReviews.Request
{
    [XmlRoot(ElementName = "product")]
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            Id = productId;
        }

        [XmlElement(ElementName = "id")]
        public int Id { get; set; }
    }
}