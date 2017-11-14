using Newtonsoft.Json;

namespace Digiseller.Client.Core.Models.Cart.Request
{
    public class UpdateRequest
    {
        public UpdateRequest()
        {

        }

        public UpdateRequest(string cartUid, int? itemUpdate, int? productCount, string currencyCode, string languageCode)
        {
            CartUid = cartUid;
            Currency = currencyCode;
            ItemId = itemUpdate?.ToString() ?? "";
            ProductCount = productCount?.ToString() ?? "";
            Language = languageCode;
        }

        [JsonProperty(PropertyName = "cart_curr")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "item_id")]
        public string ItemId { get; set; }

        [JsonProperty(PropertyName = "product_cnt")]
        public string ProductCount { get; set; }

        [JsonProperty(PropertyName = "lang")]
        public string Language { get; set; }

        [JsonProperty(PropertyName = "cart_uid")]
        public string CartUid { get; set; }

    }
}