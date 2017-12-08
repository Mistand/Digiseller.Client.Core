using System.Collections.Generic;
using System.Text;
using Digiseller.Client.Core.Models.SellerSells;

namespace Digiseller.Client.Core.Interfaces.SellerSells
{
    /// <summary>
    /// Seller sells
    /// </summary>
    public interface ISellerSells
    {
        IEnumerable<ISellRow> Rows { get; set; }

        /// <summary>
        /// Total Rows
        /// </summary>
        int TotalRows { get; set; }

        /// <summary>
        /// Total pages
        /// </summary>
        int Pages { get; set; }

        /// <summary>
        /// Current page
        /// </summary>
        int Page { get; set; }
    }
}
