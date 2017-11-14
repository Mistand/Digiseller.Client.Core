using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.ProductSearch.Request
{
    [XmlRoot(ElementName = "seller")]
    public class Seller
    {
        public Seller()
        {

        }

        public Seller(uint id)
        {
            Id = id;
        }

        [XmlElement(ElementName = "id")]
        public uint Id { get; set; }
    }
}