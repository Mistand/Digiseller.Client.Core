using Digiseller.Client.Core.Models.ProductReviews.Response;
using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.ProductReviews
{
    [XmlRoot(ElementName = "digiseller.response")]
    public class ProductReviewsResponse : ResponseXmlBase
    {
        [XmlElement(ElementName = "seller")]
        public Seller Seller { get; set; }
        [XmlElement(ElementName = "product")]
        public Product Product { get; set; }
        [XmlElement(ElementName = "pages")]
        public Pages Pages { get; set; }
        [XmlElement(ElementName = "reviews")]
        public Reviews Reviews { get; set; }
    }
}
