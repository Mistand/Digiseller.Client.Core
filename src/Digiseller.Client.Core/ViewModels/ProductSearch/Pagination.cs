using Digiseller.Client.Core.Models.ProductSearch.Response;
using Digiseller.Client.Core.Interfaces.ProductSearch;

namespace Digiseller.Client.Core.ViewModels.ProductSearch
{
    public class Pagination : IPagination
    {
        public Pagination(Pages pages)
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
