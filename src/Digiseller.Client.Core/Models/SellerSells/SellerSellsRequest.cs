using System;
using System.Collections.Generic;
using Digiseller.Client.Core.Helpers;
using Newtonsoft.Json;

namespace Digiseller.Client.Core.Models.SellerSells
{
    public class SellerSellsRequest
    {
        public SellerSellsRequest()
        {
            
        }

        public SellerSellsRequest(uint sellerId, List<int> productIds, DateTime start, DateTime finish, int returns, int rowsCount, int page, string sign, bool calculateSign = true)
        {
            SellerId = sellerId;
            ProductIds = productIds;
            Start = start.ToString("yyyy-MM-dd HH:mm:ss");
            Finish = finish.ToString("yyyy-MM-dd HH:mm:ss");
            Returned = returns;
            RowsCount = rowsCount;
            Page = page;
            Signature = calculateSign ? Crypto.SHA256($"{SellerId}{string.Join("", ProductIds)}{Start}{Finish}{Returned}{Page}{RowsCount}{sign}").ToLower() : sign;
        }

        [JsonProperty("id_seller")]
        public uint SellerId { get; set; }

        [JsonProperty("product_ids")]
        public List<int> ProductIds { get; set; }

        [JsonProperty("date_start")]
        public string Start { get; set; }

        [JsonProperty("date_finish")]
        public string Finish { get; set; }

        [JsonProperty("returned")]
        public int Returned { get; set; }

        [JsonProperty("rows")]
        public int RowsCount { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("sign")]
        public string Signature { get; set; }
    }
}
