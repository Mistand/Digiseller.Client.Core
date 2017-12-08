using System.Collections.Generic;
using Digiseller.Client.Core.Interfaces;
using Digiseller.Client.Core.Models.SellerSells.Response;
using Newtonsoft.Json;

namespace Digiseller.Client.Core.Models.SellerSells
{
    public class SellerSellsResponse : IDigisellerResponse
    {
        public bool HasErrors()
        {
            return ResponseCode != 0;
        }
        public string ErrorMessage => ResponseMessage;
        public int ErrorCode => ResponseCode;

        [JsonProperty("retval")]
        public int ResponseCode { get; set; }

        [JsonProperty("retdesc")]
        public string ResponseMessage { get; set; }

        [JsonProperty("total_rows")]
        public int TotalRows { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("rows")]
        public List<SellRow> Rows { get; set; }
    }
}
