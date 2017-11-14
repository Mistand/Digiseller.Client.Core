﻿using System.Text;

namespace Digiseller.Client.Core.Interfaces.ProductReviews
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
        /// Rows count per page
        /// </summary>
        int RowsCount { get; }

        /// <summary>
        /// Page count
        /// </summary>
        int PageCount { get; }
    }
}
