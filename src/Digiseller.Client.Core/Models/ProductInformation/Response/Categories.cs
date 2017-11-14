using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.ProductInformation.Response
{
    [XmlRoot(ElementName = "categories")]
    public class Categories
    {
        [XmlElement(ElementName = "category")]
        public Category Category { get; set; }
    }
}