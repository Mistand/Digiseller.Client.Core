using System.Collections.Generic;
using Newtonsoft.Json;

namespace Digiseller.Client.Core.Models.Cart.Response
{
    public class UpdateResponse : ResponseJsonBase
    {
        [JsonProperty(PropertyName = "cart_cnt")]
        public string CartCount { get; set; }


        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "products")]
        public List<Product> Products { get; set; }
    }
}