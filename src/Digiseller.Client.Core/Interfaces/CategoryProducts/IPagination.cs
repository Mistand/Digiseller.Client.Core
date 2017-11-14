namespace Digiseller.Client.Core.Interfaces.CategoryProducts
{
    /// <summary>
    /// Pagination
    /// </summary>
    public interface IPagination
    {

        /// <summary>
        /// Page number
        /// </summary>
        int PageNumber { get; }

        /// <summary>
        /// Count of rows
        /// </summary>
        int RowsCount { get; }

        /// <summary>
        /// Pages count
        /// </summary>
        int PagesCount { get; }
    }
}