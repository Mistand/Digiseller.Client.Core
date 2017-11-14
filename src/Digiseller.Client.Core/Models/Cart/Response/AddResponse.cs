using System.Collections.Generic;
using Newtonsoft.Json;

namespace Digiseller.Client.Core.Models.Cart.Response
{
    public class AddResponse : ResponseJson2Base
    {
        [JsonProperty(PropertyName = "cart_cnt")]
        public int CartCount { get; set; }

        [JsonProperty(PropertyName = "cart_uid")]
        public string CartUid { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "products")]
        public List<Product> Products { get; set; }
    }
}
