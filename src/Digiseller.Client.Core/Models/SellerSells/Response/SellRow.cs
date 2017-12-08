using Newtonsoft.Json;

namespace Digiseller.Client.Core.Models.SellerSells.Response
{
    public class SellRow
    {
        [JsonProperty("invoice_id")]
        public int InvoiceId { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        [JsonProperty("product_entry_id")]
        public int ProductEntryId { get; set; }

        [JsonProperty("product_entry")]
        public string ProductEntry { get; set; }

        [JsonProperty("date_put")]
        public string DatePut { get; set; }

        [JsonProperty("date_pay")]
        public string DatePay { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("wmid")]
        public string WMID { get; set; }

        [JsonProperty("amount_in")]
        public double AmountIn { get; set; }

        [JsonProperty("amount_out")]
        public double AmountOut { get; set; }

        [JsonProperty("amount_currency")]
        public string AmountCurrency { get; set; }

        [JsonProperty("method_pay")]
        public string MethodPay { get; set; }

        [JsonProperty("ip")]
        public string IpAddress { get; set; }

        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("returned")]
        public int Returned { get; set; }
    }
}
