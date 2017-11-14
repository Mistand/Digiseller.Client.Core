using System.Xml.Serialization;
using Digiseller.Client.Core.Models.ProductInformation.Response;
namespace Digiseller.Client.Core.Models.ProductInformation
{
    [XmlRoot(ElementName = "digiseller.response")]
    public class ProductInformationResponse : ResponseXmlBase 
    {
        [XmlElement(ElementName = "product")]
        public Product Product { get; set; }
    }
}
