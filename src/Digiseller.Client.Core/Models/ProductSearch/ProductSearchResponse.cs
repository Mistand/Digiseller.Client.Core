using System.Xml.Serialization;
using Digiseller.Client.Core.Models.ProductSearch.Response;

namespace Digiseller.Client.Core.Models.ProductSearch
{
    [XmlRoot(ElementName = "digiseller.response")]
    public class ProductSearchResponse : ResponseXmlBase
    {
        [XmlElement(ElementName = "pages")]
        public Pages Pages { get; set; }
        [XmlElement(ElementName = "products")]
        public Products Products { get; set; }
    }
}
