using System.Collections.Generic;
using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.CategoryProducts.Response
{
    [XmlRoot(ElementName = "subcategories")]
    public class Subcategories
    {
        [XmlElement(ElementName = "subcategory")]
        public List<Subcategory> Subcategory { get; set; }
    }
}