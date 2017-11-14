using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.Categories
{
    public class CategoriesResponse : ResponseXmlBase
    {
        [XmlElement(ElementName = "categories")]
        public Response.Categories Categories { get; set; }
    }
}
