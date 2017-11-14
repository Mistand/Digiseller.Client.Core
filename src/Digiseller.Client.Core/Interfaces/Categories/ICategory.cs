using System.Collections.Generic;

namespace Digiseller.Client.Core.Interfaces.Categories
{
    /// <summary>
    /// Catalog of categories
    /// </summary>
    public interface ICategory
    {
        /// <summary>
        /// Id
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Name of this category
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Child categories
        /// </summary>
        IEnumerable<ICategory> ChildCategories { get; }
    }
}
