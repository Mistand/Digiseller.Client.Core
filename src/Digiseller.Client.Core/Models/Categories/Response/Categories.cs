﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.Categories.Response
{
    [XmlRoot(ElementName = "categories")]
    public class Categories
    {
        [XmlElement(ElementName = "category")]
        public List<Category> Category { get; set; }
    }
}