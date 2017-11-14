using System.Xml.Serialization;
using Digiseller.Client.Core.Enums;
using Digiseller.Client.Core.Models.ProductDiscounts.Request;
namespace Digiseller.Client.Core.Models.ProductDiscounts
{
    [XmlRoot(ElementName = "digiseller.request")]
    public class ProductDiscountRequest
    {
        public ProductDiscountRequest()
        {

        }

        public ProductDiscountRequest(int productId, string email, Currency currency = Currency.RUR)
        {
            Product = new Product(productId, currency.ToString());
            Email = email;
        }

        [XmlElement(ElementName = "product")]
        public Product Product { get; set; }
        [XmlElement(ElementName = "email")]
        public string Email { get; set; }
    }
}
