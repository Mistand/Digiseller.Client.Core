using Digiseller.Client.Core.Enums;
using Newtonsoft.Json;

namespace Digiseller.Client.Core.Models.Cart.Request
{
    public class AddRequest
    {
        public AddRequest()
        {
            
        }
        public AddRequest(int productId, int productCount, Currency currency, string email, string languageCode, string cartUid = "")
        {
            ProductId = productId;
            ProductCount = productCount;
            CurrencyType = currency.ToString();
            Email = email;
            Lang = languageCode;
            CartUid = cartUid;
        }
        [JsonProperty(PropertyName = "product_id")]
        public int ProductId { get; set; }

        [JsonProperty(PropertyName = "product_cnt")]
        public int ProductCount { get; set; }

        [JsonProperty(PropertyName = "typecurr")]
        public string CurrencyType { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "lang")]
        public string Lang { get; set; }

        [JsonProperty(PropertyName = "cart_uid")]
        public string CartUid { get; set; }
    }
}
