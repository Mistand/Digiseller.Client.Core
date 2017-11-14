using Newtonsoft.Json;

namespace Digiseller.Client.Core.Models.Cart.Response
{
    public class Product
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "item_id")]
        public int ItemId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "available")]
        public int Available { get; set; }

        [JsonProperty(PropertyName = "price")]
        public string Price { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "cnt_item")]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "cnt_lock")]
        public int CntLock { get; set; }
    }
}