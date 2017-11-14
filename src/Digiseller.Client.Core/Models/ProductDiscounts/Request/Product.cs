using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.ProductDiscounts.Request
{
    [XmlRoot(ElementName = "product")]
    public class Product
    {
        public Product()
        {

        }

        public Product(int id, string currencyCode)
        {
            Id = id;
            Currency = currencyCode;
        }

        [XmlElement(ElementName = "id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "currency")]
        public string Currency { get; set; }
    }
}
