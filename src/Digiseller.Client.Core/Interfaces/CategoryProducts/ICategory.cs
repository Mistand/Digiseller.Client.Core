namespace Digiseller.Client.Core.Interfaces.CategoryProducts
{
    /// <summary>
    /// ICategory
    /// </summary>
    public interface ICategory : ISubcategory
    {
        ICategory ChildCategory { get; }
    }
}
