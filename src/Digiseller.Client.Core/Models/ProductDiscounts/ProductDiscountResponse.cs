using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Digiseller.Client.Core.Models.ProductDiscounts.Response;
namespace Digiseller.Client.Core.Models.ProductDiscounts
{
    [XmlRoot(ElementName = "digiseller.response")]
    public class ProductDiscountResponse : ResponseXmlBase
    {
        [XmlElement(ElementName = "product")]
        public Product Product { get; set; }
        [XmlElement(ElementName = "discount")]
        public Discount Discount { get; set; }
    }
}
