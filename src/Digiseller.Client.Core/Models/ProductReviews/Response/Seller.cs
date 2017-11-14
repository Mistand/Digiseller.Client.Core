using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.ProductReviews.Response
{
    [XmlRoot(ElementName = "seller")]
    public class Seller
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }
    }
}