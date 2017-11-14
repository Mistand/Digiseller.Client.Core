using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.CategoryProducts.Request
{
    [XmlRoot(ElementName = "seller")]
    public class Seller
    {
        /// <summary>
        ///     For serialization
        /// </summary>
        public Seller() { }

        public Seller(uint sellerId)
        {
            Id = sellerId;
        }

        [XmlElement(ElementName = "id")]
        public uint Id { get; set; }
    }
}