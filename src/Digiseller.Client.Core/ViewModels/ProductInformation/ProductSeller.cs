using Digiseller.Client.Core.Interfaces.ProductInformation;
using Digiseller.Client.Core.Models.ProductInformation.Response;

namespace Digiseller.Client.Core.ViewModels.ProductInformation
{
    public class ProductSeller : IFullSeller
    {
        public int Id { get; }
        public string Username { get; }

        public ProductSeller(Seller seller)
        {
            Id = seller.Id;
            Username = seller.Name;
        }
    }
}