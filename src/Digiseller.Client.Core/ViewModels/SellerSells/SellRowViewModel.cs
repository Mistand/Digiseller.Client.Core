using System;
using Digiseller.Client.Core.Interfaces.SellerSells;
using Digiseller.Client.Core.Models.SellerSells.Response;

namespace Digiseller.Client.Core.ViewModels.SellerSells
{
    public class SellRowViewModel : ISellRow
    {
        public SellRowViewModel(SellRow row)
        {
            InvoiceId = row.InvoiceId;
            ProductId = row.ProductId;
            ProductName = row.ProductName;
            ProductEntryId = row.ProductEntryId;
            DatePut = DateTime.TryParse(row.DatePut, out var putDateTime) ? putDateTime : (DateTime?)null;
            DatePay = DateTime.TryParse(row.DatePut, out var payDateTime) ? payDateTime : (DateTime?)null;
            Email = row.Email;
            WMID = row.WMID;
            AmountIn = row.AmountIn;
            AmountOut = row.AmountOut;
            MethodPay = row.MethodPay;
            IpAddress = row.IpAddress;
            PartnerId = row.PartnerId;
            Lang = row.Lang;
            Returned = row.Returned == 1;
        }

        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductEntryId { get; set; }
        public string ProductEntry { get; set; }
        public DateTime? DatePut { get; set; }
        public DateTime? DatePay { get; set; }
        public string Email { get; set; }
        public string WMID { get; set; }
        public double AmountIn { get; set; }
        public double AmountOut { get; set; }
        public string AmountCurrency { get; set; }
        public string MethodPay { get; set; }
        public string IpAddress { get; set; }
        public string PartnerId { get; set; }
        public string Lang { get; set; }
        public bool Returned { get; set; }
    }
}