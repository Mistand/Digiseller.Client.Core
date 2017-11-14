using System.Xml.Serialization;
using Digiseller.Client.Core.Interfaces;

namespace Digiseller.Client.Core.Models
{
    public abstract class ResponseXmlBase : IDigisellerResponse
    {
        [XmlElement(ElementName = "retval")]
        public int ErrorCode { get; set; }

        [XmlElement(ElementName = "retdesc")]
        public string ErrorMessage { get; set; }

        public bool HasErrors()
        {
            return ErrorCode != 0;
        }
    }
}