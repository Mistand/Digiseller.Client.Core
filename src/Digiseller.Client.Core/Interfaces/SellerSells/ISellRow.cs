using System;

namespace Digiseller.Client.Core.Interfaces.SellerSells
{
    /// <summary>
    /// Sell row
    /// </summary>
    public interface ISellRow
    {
        /// <summary>
        /// Invoce ID
        /// </summary>
        int InvoiceId { get; set; }

        /// <summary>
        /// Product Id
        /// </summary>
        int ProductId { get; set; }

        /// <summary>
        /// Product Name
        /// </summary>
        string ProductName { get; set; }

        /// <summary>
        /// Product Entry Id
        /// </summary>
        int ProductEntryId { get; set; }

        /// <summary>
        /// Product entry
        /// </summary>
        string ProductEntry { get; set; }

        /// <summary>
        /// Date of put
        /// </summary>
        DateTime? DatePut { get; set; }
        
        /// <summary>
        /// Date of pay
        /// </summary>
        DateTime? DatePay { get; set; }

        /// <summary>
        /// Email buyer
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// WMID buyer
        /// </summary>
        string WMID { get; set; }

        /// <summary>
        /// Amount paid by the buyer 
        /// </summary>
        double AmountIn { get; set; }

        /// <summary>
        /// The amount that was credited to the account
        /// </summary>
        double AmountOut { get; set; }

        /// <summary>
        /// Amount currency
        /// </summary>
        string AmountCurrency { get; set; }
        
        /// <summary>
        /// Method of pay
        /// </summary>
        string MethodPay { get; set; }

        /// <summary>
        /// IpAddress of the buyer
        /// </summary>
        string IpAddress { get; set; }

        /// <summary>
        /// Partner id
        /// </summary>
        string PartnerId { get; set; }

        /// <summary>
        /// Language of the buyer
        /// </summary>
        string Lang { get; set; }

        /// <summary>
        /// Purchase return
        /// </summary>
        bool Returned { get; set; }
    }
}