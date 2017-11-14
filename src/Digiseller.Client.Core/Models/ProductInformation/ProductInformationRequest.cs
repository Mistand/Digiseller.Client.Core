using System.Xml.Serialization;
using Digiseller.Client.Core.Models.ProductInformation.Request;

namespace Digiseller.Client.Core.Models.ProductInformation
{
    [XmlRoot(ElementName = "digiseller.request")]
    public class ProductInformationRequest
    {
        public ProductInformationRequest() { }
        public ProductInformationRequest(uint sellerId, int productId, string agentUid, string languageCode)
        {
            Product = new Product(productId);
            Seller = new Seller(sellerId);
            PartnerUid = agentUid;
            Lang = languageCode;
        }

        [XmlElement(ElementName = "product")]
        public Product Product { get; set; }
        [XmlElement(ElementName = "seller")]
        public Seller Seller { get; set; }
        [XmlElement(ElementName = "partner_uid")]
        public string PartnerUid { get; set; }
        [XmlElement(ElementName = "lang")]
        public string Lang { get; set; }
    }
}
