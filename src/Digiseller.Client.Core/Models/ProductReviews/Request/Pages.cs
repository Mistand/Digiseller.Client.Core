using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.ProductReviews.Request
{
    [XmlRoot(ElementName = "pages")]
    public class Pages
    {
        public Pages()
        {

        }

        public Pages(int pageNumber, int rowsCount)
        {
            Num = pageNumber;
            Rows = rowsCount;
        }

        [XmlElement(ElementName = "num")]
        public int Num { get; set; }
        [XmlElement(ElementName = "rows")]
        public int Rows { get; set; }
    }
}
