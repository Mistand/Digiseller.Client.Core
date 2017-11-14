using System.Globalization;
using Digiseller.Client.Core.Interfaces.ProductSearch;

namespace Digiseller.Client.Core.ViewModels.ProductSearch
{
    public class Product : IProduct
    {
        public Product(Models.ProductSearch.Response.Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Price = decimal.Parse(product.Price, NumberStyles.Currency);
            AgencyFee = (int)decimal.Parse(product.AgencyFee, NumberStyles.Currency);
            if (product.Snippets != null)
                Snippet = new Snippet(product.Snippets);
        }

        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public int AgencyFee { get; }
        public ISnippet Snippet { get; }
    }
}