using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.ProductDiscounts.Response
{
    [XmlRoot(ElementName = "discount")]
    public class Discount
    {
        [XmlElement(ElementName = "percent")]
        public int Percent { get; set; }
        [XmlElement(ElementName = "total")]
        public string Total { get; set; }
        [XmlElement(ElementName = "currency")]
        public string Currency { get; set; }
    }
}
