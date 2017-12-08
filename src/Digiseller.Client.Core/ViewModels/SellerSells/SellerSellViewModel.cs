using System.Collections.Generic;
using System.Linq;
using Digiseller.Client.Core.Interfaces.SellerSells;
using Digiseller.Client.Core.Models.SellerSells;

namespace Digiseller.Client.Core.ViewModels.SellerSells
{
    public class SellerSellViewModel : ISellerSells
    {
        public SellerSellViewModel(SellerSellsResponse response)
        {
            TotalRows = response.TotalRows;
            Pages = response.Pages;
            Page = response.Page;

            Rows = new List<ISellRow>();
            if (response.Rows != null)
                Rows = response.Rows.Select(a => new SellRowViewModel(a));
        }

        public IEnumerable<ISellRow> Rows { get; set; }
        public int TotalRows { get; set; }
        public int Pages { get; set; }
        public int Page { get; set; }
    }
}
