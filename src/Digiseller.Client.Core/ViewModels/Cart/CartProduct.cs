using System;
using System.Globalization;
using Digiseller.Client.Core.Enums;
using Digiseller.Client.Core.Interfaces.Cart;
using Digiseller.Client.Core.Models.Cart.Response;

namespace Digiseller.Client.Core.ViewModels.Cart
{
    public class CartProduct : ICartProduct
    {
        public CartProduct(Product prod)
        {
            Id = prod.Id;
            ItemId = prod.ItemId;
            Name = prod.Name;
            Aviable = prod.Available != 0;
            Price = decimal.Parse(prod.Price, NumberStyles.Currency);
            Currency = Enum.TryParse(prod.Currency, out Currency currency) ? currency : (Currency?)null;
            CountItem = prod.Count;
            CountLock = prod.CntLock;
        }

        public int Id { get; }
        public int ItemId { get; }
        public string Name { get; }
        public bool Aviable { get; }
        public decimal Price { get; }
        public Currency? Currency { get; }
        public int CountItem { get; }
        public int CountLock { get; }
    }
}