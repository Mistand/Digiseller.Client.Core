using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.ProductInformation.Response
{
    [XmlRoot(ElementName = "statistics")]
    public class Statistics
    {
        [XmlElement(ElementName = "sales")]
        public int Sales { get; set; }
        [XmlElement(ElementName = "refunds")]
        public int Refunds { get; set; }
        [XmlElement(ElementName = "good_reviews")]
        public int GoodReviews { get; set; }
        [XmlElement(ElementName = "bad_reviews")]
        public int BadReviews { get; set; }
    }
}