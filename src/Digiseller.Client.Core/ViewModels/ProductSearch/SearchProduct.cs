using System.Collections.Generic;
using System.Linq;
using Digiseller.Client.Core.Interfaces.ProductSearch;
using Digiseller.Client.Core.Models.ProductSearch;

namespace Digiseller.Client.Core.ViewModels.ProductSearch
{
    public class SearchProduct : ISearchProduct
    {
        public SearchProduct(ProductSearchResponse responseXml)
        {
            if (responseXml.Pages != null)
                Pagination = new Pagination(responseXml.Pages);

            Products = new List<IProduct>();
            if (responseXml.Products?.Product?.Count > 0)
                Products = responseXml.Products?.Product?.Select(p => new Product(p));
        }

        public IPagination Pagination { get; }
        public IEnumerable<IProduct> Products { get; }
    }
}