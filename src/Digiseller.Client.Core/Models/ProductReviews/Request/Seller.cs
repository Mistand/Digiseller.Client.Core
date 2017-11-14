using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.ProductReviews.Request
{
    [XmlRoot(ElementName = "seller")]
    public class Seller
    {
        [XmlElement(ElementName = "id")]
        public uint Id { get; set; }

        public Seller()
        {

        }

        public Seller(uint sellerId)
        {
            Id = sellerId;
        }
    }
}