using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.ProductReviews.Response
{
    [XmlRoot(ElementName = "product")]
    public class Product
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }
    }
}