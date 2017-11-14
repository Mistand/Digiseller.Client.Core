using System.Collections.Generic;
using System.Linq;
using Digiseller.Client.Core.Interfaces.Categories;

namespace Digiseller.Client.Core.ViewModels
{
    public class Category : ICategory
    {
        private readonly Models.Categories.Response.Category _category;
 
        public Category(Models.Categories.Response.Category category)
        {
            _category = category;

            ChildCategories = new List<ICategory>();

            if (_category.ChildCategories?.Count() > 0)
            {
                ChildCategories = _category.ChildCategories.Select(p => new Category(p));
            }
        }

        public int Id => _category.Id;
        public string Name => _category.Name;
        public IEnumerable<ICategory> ChildCategories { get; }
    }
}