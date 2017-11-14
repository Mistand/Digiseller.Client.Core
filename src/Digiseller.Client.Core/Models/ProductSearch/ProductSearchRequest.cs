using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Digiseller.Client.Core.Models.ProductSearch.Request;
namespace Digiseller.Client.Core.Models.ProductSearch
{
    [XmlRoot(ElementName = "digiseller.request")]
    public class ProductSearchRequest
    {
        public ProductSearchRequest() { }
        public ProductSearchRequest(uint sellerId, string search, string currencyCode, int pageNumber = 1, int rowsCount = 20)
        {
            Seller = new Seller(sellerId);
            Products = new Products(search, currencyCode);
            Pages = new Pages(pageNumber, rowsCount);
        }

        [XmlElement(ElementName = "seller")]
        public Seller Seller { get; set; }
        [XmlElement(ElementName = "products")]
        public Products Products { get; set; }
        [XmlElement(ElementName = "pages")]
        public Pages Pages { get; set; }
    }
}
