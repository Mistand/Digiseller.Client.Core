using Digiseller.Client.Core.Interfaces.CategoryProducts;
using Digiseller.Client.Core.Models.CategoryProducts.Response;

namespace Digiseller.Client.Core.ViewModels.CategoryProducts
{
    public class Pagination : IPagination
    {
        public Pagination(Pages pages)
        {
            PageNumber = pages.PageNumber;
            RowsCount = pages.RowsCount;
            PagesCount = pages.PagesCount;
        }

        public int PageNumber { get; }
        public int RowsCount { get; }
        public int PagesCount { get; }
    }
}