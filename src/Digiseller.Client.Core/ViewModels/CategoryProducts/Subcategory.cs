using Digiseller.Client.Core.Interfaces.CategoryProducts;

namespace Digiseller.Client.Core.ViewModels.CategoryProducts
{
    public class Subcategory : ISubcategory
    {
        public Subcategory(Models.CategoryProducts.Response.Subcategory category)
        {
            Id = category.Id;
            Name = category.Name;
            GoodsCount = category.Cnt;
        }

        public int Id { get; }
        public string Name { get; }
        public int GoodsCount { get; }
    }
}