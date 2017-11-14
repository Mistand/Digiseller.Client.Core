using System.Collections.Generic;
using System.Linq;
using Digiseller.Client.Core.Interfaces.CategoryProducts;
using Digiseller.Client.Core.Models.CategoryProducts;

namespace Digiseller.Client.Core.ViewModels.CategoryProducts
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository(CategoryProductsResponse productRep)
        { // Digiseller periodically buggy, always check for null.
            Goods = new List<IProduct>();
            if (productRep.Products?.Product?.Count > 0)
                Goods = productRep.Products?.Product?.Select(p => new Product(p));

            if (productRep.Pages != null)
                Pagination = new Pagination(productRep.Pages);

            if (productRep.Categories?.Category != null)
                Category = new Category(productRep.Categories.Category);

            Subcategories = new List<ISubcategory>();
            if (productRep.Subcategories?.Subcategory?.Count > 0)
                Subcategories = productRep.Subcategories?.Subcategory?.Select(p => new Subcategory(p));
        }

        public IEnumerable<IProduct> Goods { get; }
        public IPagination Pagination { get; }
        public ICategory Category { get; }
        public IEnumerable<ISubcategory> Subcategories { get; }
    }
}