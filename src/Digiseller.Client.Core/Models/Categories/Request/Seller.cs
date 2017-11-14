using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.Categories.Request
{
    [XmlRoot(ElementName = "seller")]
    public class Seller
    {
        public Seller() { }
        public Seller(uint sellerId)
        {
            Id = sellerId;
        }

        [XmlElement(ElementName = "id")]
        public uint Id { get; set; }
    }
}