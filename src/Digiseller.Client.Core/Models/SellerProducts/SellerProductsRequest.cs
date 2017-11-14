using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.SellerProducts
{
    [XmlRoot(ElementName = "digiseller.request")]
    public class SellerProductsRequest
    {
        public SellerProductsRequest() { }
        public SellerProductsRequest(uint sellerId, string orderColumn, string orderDir, int rowsCount, int pageNumber, string currencyCode, string languageCode)
        {
            IdSeller = sellerId;
            OrderCol = orderColumn;
            OrderDir = orderDir;
            Rows = rowsCount;
            Page = pageNumber;
            Currency = currencyCode;
            Lang = languageCode;
        }

        [XmlElement(ElementName = "id_seller")]
        public uint IdSeller { get; set; }
        [XmlElement(ElementName = "order_col")]
        public string OrderCol { get; set; }
        [XmlElement(ElementName = "order_dir")]
        public string OrderDir { get; set; }
        [XmlElement(ElementName = "rows")]
        public int Rows { get; set; }
        [XmlElement(ElementName = "page")]
        public int Page { get; set; }
        [XmlElement(ElementName = "currency")]
        public string Currency { get; set; }
        [XmlElement(ElementName = "lang")]
        public string Lang { get; set; }
    }
}
