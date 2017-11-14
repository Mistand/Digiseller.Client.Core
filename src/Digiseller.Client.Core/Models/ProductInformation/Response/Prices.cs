using System.Xml.Serialization;

namespace Digiseller.Client.Core.Models.ProductInformation.Response
{
    [XmlRoot(ElementName = "prices")]
    public class Prices
    {
        [XmlElement(ElementName = "wmz")]
        public decimal Wmz { get; set; }
        [XmlElement(ElementName = "wmr")]
        public decimal Wmr { get; set; }
        [XmlElement(ElementName = "wme")]
        public decimal Wme { get; set; }
        [XmlElement(ElementName = "wmu")]
        public decimal Wmu { get; set; }
        [XmlElement(ElementName = "wmx")]
        public decimal Wmx { get; set; }
        [XmlElement(ElementName = "rcc")]
        public decimal Rcc { get; set; }
        [XmlElement(ElementName = "zcc")]
        public decimal Zcc { get; set; }
        [XmlElement(ElementName = "ecc")]
        public decimal Ecc { get; set; }
        [XmlElement(ElementName = "mts")]
        public decimal Mts { get; set; }
        [XmlElement(ElementName = "bln")]
        public decimal Bln { get; set; }
        [XmlElement(ElementName = "mgf")]
        public decimal Mgf { get; set; }
        [XmlElement(ElementName = "tl2")]
        public decimal Tl2 { get; set; }
        [XmlElement(ElementName = "pcr")]
        public decimal Pcr { get; set; }
        [XmlElement(ElementName = "mrr")]
        public decimal Mrr { get; set; }
        [XmlElement(ElementName = "qsr")]
        public decimal Qsr { get; set; }
        [XmlElement(ElementName = "atm")]
        public decimal Atm { get; set; }
        [XmlElement(ElementName = "rub")]
        public decimal Rub { get; set; }
        [XmlElement(ElementName = "bnk")]
        public decimal Bnk { get; set; }
    }
}