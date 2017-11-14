using Digiseller.Client.Core.Interfaces.ProductInformation;
using Digiseller.Client.Core.Models.ProductInformation.Response;

namespace Digiseller.Client.Core.ViewModels.ProductInformation
{
    public class ProductStatistics : IStatistics
    {
        public int Sales { get; }
        public int Refunds { get; }
        public int GoodReviews { get; }
        public int BadReviews { get; }

        public ProductStatistics(Statistics stats)
        {
            Sales = stats.Sales;
            Refunds = stats.Refunds;
            GoodReviews = stats.GoodReviews;
            BadReviews = stats.BadReviews;
        }
    }
}