using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.ProductSearch.Response
{
    [XmlRoot(ElementName = "snippets")]
    public class Snippets
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "info")]
        public string Info { get; set; }
    }
}