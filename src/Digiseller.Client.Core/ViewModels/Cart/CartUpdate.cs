using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Digiseller.Client.Core.Enums;
using Digiseller.Client.Core.Interfaces.Cart;
using Digiseller.Client.Core.Models.Cart.Response;

namespace Digiseller.Client.Core.ViewModels.Cart
{
    public class CartUpdate : ICartUpdate
    {
        public CartUpdate(UpdateResponse res)
        {
            CartPrice = decimal.Parse(res.Amount, NumberStyles.Currency);
            Currency = Enum.TryParse(res.Currency, out Currency result) ? result : (Currency?)null;
            Products = new List<ICartProduct>();
            if (res.Products?.Count > 0)
                Products = res.Products?.Select(p => new CartProduct(p));

        }

        public decimal? CartPrice { get; }
        public Currency? Currency { get; }
        public IEnumerable<ICartProduct> Products { get; }
    }
}