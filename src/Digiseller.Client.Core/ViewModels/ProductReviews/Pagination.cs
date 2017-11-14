using Digiseller.Client.Core.Interfaces.ProductReviews;

namespace Digiseller.Client.Core.ViewModels.ProductReviews
{
    public class Pagination : IPagination
    {
        public Pagination(Models.ProductReviews.Response.Pages pages)
        {
            PageNumber = pages.Num;
            RowsCount = pages.Rows;
            PageCount = pages.Cnt;
        }

        public int PageNumber { get; }
        public int RowsCount { get; }
        public int PageCount { get; }
    }
}
