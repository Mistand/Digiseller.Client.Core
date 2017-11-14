using System.Xml.Serialization;
using Digiseller.Client.Core.Models.CategoryProducts.Response;

namespace Digiseller.Client.Core.Models.CategoryProducts
{
    [XmlRoot(ElementName = "digiseller.response")]
    public class CategoryProductsResponse : ResponseXmlBase
    {
        [XmlElement(ElementName = "categories")]
        public Response.Categories Categories { get; set; }
        [XmlElement(ElementName = "seller")]
        public Seller Seller { get; set; }
        [XmlElement(ElementName = "pages")]
        public Pages Pages { get; set; }
        [XmlElement(ElementName = "subcategories")]
        public Subcategories Subcategories { get; set; }
        [XmlElement(ElementName = "products")]
        public Products Products { get; set; }
    }
}
