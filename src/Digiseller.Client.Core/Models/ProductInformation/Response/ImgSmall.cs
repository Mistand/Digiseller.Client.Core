﻿using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.ProductInformation.Response
{
    [XmlRoot(ElementName = "img_small")]
    public class ImgSmall
    {
        [XmlAttribute(AttributeName = "height")]
        public int Height { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public int Width { get; set; }
        [XmlText]
        public string Url { get; set; }
    }
}