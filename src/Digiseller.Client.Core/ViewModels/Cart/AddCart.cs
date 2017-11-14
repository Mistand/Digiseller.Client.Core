using System;
using System.Collections.Generic;
using System.Linq;
using Digiseller.Client.Core.Enums;
using Digiseller.Client.Core.Models.Cart.Response;
using Digiseller.Client.Core.Interfaces.Cart;

namespace Digiseller.Client.Core.ViewModels.Cart
{
    public class AddCart : ICartAdd
    {
        public AddCart(AddResponse res)
        {
            ProductsCount = res.CartCount;
            CartUid = res.CartUid;
            Currency = Enum.TryParse(res.Currency, out Currency result) ? result : (Currency?)null;
            Products = new List<ICartProduct>();
            if (res.Products?.Count > 0)
                Products = res.Products?.Select(p => new CartProduct(p));

        }

        public int ProductsCount { get; }
        public string CartUid { get; }
        public Currency? Currency { get; }
        public IEnumerable<ICartProduct> Products { get; }
    }
}
