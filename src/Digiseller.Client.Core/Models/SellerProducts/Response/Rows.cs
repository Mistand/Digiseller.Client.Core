using System.Collections.Generic;
using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.SellerProducts.Response
{
    [XmlRoot(ElementName = "rows")]
    public class Rows
    {
        [XmlElement(ElementName = "row")]
        public List<Row> Row { get; set; }
        [XmlAttribute(AttributeName = "cnt")]
        public string Cnt { get; set; }
    }
}
