using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.Categories.Response
{
    [XmlRoot(ElementName = "category")]
    public class Category
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "cnt")]
        public int Cnt { get; set; }
        [XmlElement(ElementName = "category")]
        public List<Category> ChildCategories { get; set; }
    }
}
