﻿using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.ProductInformation.Response
{
    [XmlRoot(ElementName = "discount")]
    public class Discount
    {
        [XmlElement(ElementName = "summa")]
        public decimal Summa { get; set; }
        [XmlElement(ElementName = "percent")]
        public int Percent { get; set; }
    }
}