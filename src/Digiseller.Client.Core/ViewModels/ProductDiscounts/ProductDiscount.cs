using System;
using System.Globalization;
using Digiseller.Client.Core.Enums;
using Digiseller.Client.Core.Models.ProductDiscounts;
using Digiseller.Client.Core.Interfaces.ProductDiscounts;


namespace Digiseller.Client.Core.ViewModels.ProductDiscounts
{
    public class ProductDiscount : IProductDiscount
    {
        public ProductDiscount(ProductDiscountResponse responseXml)
        {
            ProductPrice = !string.IsNullOrEmpty(responseXml.Product?.Price) ? decimal.Parse(responseXml.Product?.Price, NumberStyles.Currency) : 0.0M;
            if (responseXml.Product?.Currency.Length > 2)
            {
                var typeString = char.ToUpperInvariant(responseXml.Product.Currency[0]) + responseXml.Product?.Currency.Substring(1);
                ProductCurrency = Enum.TryParse(typeString, out Currency currency) ? currency : (Currency?)null;
            }
            DiscountPercent = responseXml?.Discount?.Percent ?? -1;
            Total = !string.IsNullOrEmpty(responseXml.Discount?.Total) ? decimal.Parse(responseXml.Discount?.Total, NumberStyles.Currency) : 0.0M;
            if (responseXml.Discount?.Currency.Length > 2)
            {
                var typeString = char.ToUpperInvariant(responseXml.Discount.Currency[0]) + responseXml.Discount?.Currency.Substring(1);
                TotalCurrency = Enum.TryParse(typeString, out Currency currency) ? currency : (Currency?)null;
            }
        }

        public decimal ProductPrice { get; }
        public Currency? ProductCurrency { get; }
        public int DiscountPercent { get; }
        public decimal Total { get; }
        public Currency? TotalCurrency { get; }
    }
}
