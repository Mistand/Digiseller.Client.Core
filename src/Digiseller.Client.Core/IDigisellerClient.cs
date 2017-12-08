using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Digiseller.Client.Core.Enums;

namespace Digiseller.Client.Core
{
    /// <summary>
    /// Digiseller client
    /// </summary>
    public interface IDigisellerClient
    {
        /// <summary>
        /// Identificator of seller from digiseller system
        /// </summary>
        uint SellerId { get; set; }

        /// <summary>
        /// Unique identificator of seller from digiseller system
        /// </summary>
        string SellerUid { get; set; }

        /// <summary>
        /// Get categories with current sellerid
        /// </summary>
        /// <param name="rootCategory">Root category
        /// 0 - All categories</param>
        /// <param name="language">Language</param>
        /// <returns></returns>
        Task<IEnumerable<Interfaces.Categories.ICategory>> GetCategoriesAsync(int rootCategory = 0, Language language = Language.Russian);

        /// <summary>
        /// Get goods from category
        /// </summary>
        /// <param name="categoryId">Category identifier
        ///  0 - Goods on main page
        ///  -1 - goods with icon "sale"
        ///  -2 - goods with icon "new"
        ///  -3 - goods with icon "popular"
        /// </param>
        /// <param name="language">Language information</param>
        /// <param name="pageNumber">Page number (pagination)</param>
        /// <param name="countGoods">Count of goods per page</param>
        /// <param name="currency">Currency for information</param>
        /// <param name="sorting">Sorting</param>
        /// <returns></returns>
        Task<Interfaces.CategoryProducts.IProductRepository> GetCategoryGoodsAsync(int categoryId = 0,
            Language language = Language.Russian,
            int pageNumber = 1, int countGoods = 20, Currency currency = Currency.RUR, Sorting sorting = Sorting.name);

        /// <summary>
        /// Get full product information
        /// </summary>
        /// <param name="productId">Product Id</param>
        /// <param name="language">Language information</param>
        /// <returns></returns>
        Task<Interfaces.ProductInformation.IProduct> GetProductAsync(int productId, Language language = Language.Russian);

        /// <summary>
        /// Get product reviews
        /// </summary>
        /// <param name="productId">Product id</param>
        /// <param name="reviewType">Type of reviews</param>
        /// <param name="pageNumber">Page number (pagination)</param>
        /// <param name="rowsCount">Count of reviews per page</param>
        /// <returns></returns>
        Task<Interfaces.ProductReviews.IProductReviews> GetProductReviews(int productId, ReviewType reviewType = ReviewType.All, int pageNumber = 1, int rowsCount = 20);

        /// <summary>
        /// Get products by current seller
        /// </summary>
        /// <param name="pageNumber">Page number (pagination)</param>
        /// <param name="rowsCount">Count of products per page</param>
        /// <param name="currency">Currency for prices</param>
        /// <param name="orderColumn">Sorting column</param>
        /// <param name="orderDir">Sorting by</param>
        /// <param name="language">Language information</param>
        /// <returns></returns>
        Task<Interfaces.SellerProducts.ISellerProducts> GetSellerProducts(int pageNumber = 1, int rowsCount = 20, Currency currency = Currency.RUR,
            OrderColumn orderColumn = OrderColumn.Name, OrderDir orderDir = OrderDir.Asc,
            Language language = Language.Russian);

        /// <summary>
        /// Get products by seller id
        /// </summary>
        /// <param name="sellerId">Seller Id</param>
        /// <param name="pageNumber">Page number (pagination)</param>
        /// <param name="rowsCount">Count of products per page</param>
        /// <param name="currency">Currency for prices</param>
        /// <param name="orderColumn">Sorting column</param>
        /// <param name="orderDir">Sorting by</param>
        /// <param name="language">Language information</param>
        /// <returns></returns>
        Task<Interfaces.SellerProducts.ISellerProducts> GetSellerProducts(uint sellerId, int pageNumber = 1, int rowsCount = 20, Currency currency = Currency.RUR,
            OrderColumn orderColumn = OrderColumn.Name, OrderDir orderDir = OrderDir.Asc,
            Language language = Language.Russian);

        /// <summary>
        /// Get product discount by buyer email
        /// </summary>
        /// <param name="productId">Product Id</param>
        /// <param name="email">Buyer email</param>
        /// <param name="currency">Currency</param>
        /// <returns></returns>
        Task<Interfaces.ProductDiscounts.IProductDiscount> GetProductDiscount(int productId, string email, Currency currency = Currency.RUR);

        /// <summary>
        /// Get goods by search string
        /// </summary>
        /// <param name="searchString">Search string</param>
        /// <param name="pageNumber">Page number (pagination)</param>
        /// <param name="rowsCount">Count of goods per page</param>
        /// <param name="currency">Currency</param>
        /// <returns></returns>
        Task<Interfaces.ProductSearch.ISearchProduct> GetGoodsBySearchString(string searchString, int pageNumber = 1, int rowsCount = 10, Currency currency = Currency.RUR);

        /// <summary>
        /// Add product to cart
        /// </summary>
        /// <param name="productId">Product id</param>
        /// <param name="productCount">Product count</param>
        /// <param name="email">Buyer email</param>
        /// <param name="cartUid">Cart UID (optional)</param>
        /// <param name="currency">Currency</param>
        /// <param name="language">Language information</param>
        /// <returns></returns>
        Task<Interfaces.Cart.ICartAdd> AddToCart(int productId, int productCount, string email, string cartUid = "", Currency currency = Currency.RUR, Language language = Language.Russian);

        /// <summary>
        /// Update cart
        /// </summary>
        /// <param name="cartUid">Cart UID</param>
        /// <param name="itemUpdate">item id for update (optional)</param>
        /// <param name="productCount">Product Count (optional, required if itemUpdate != null)</param>
        /// <param name="currency">Currency</param>
        /// <param name="language">Language information</param>
        /// <returns></returns>
        Task<Interfaces.Cart.ICartUpdate> UpdateCart(string cartUid, int? itemUpdate = null, int? productCount = null, Currency currency = Currency.RUR, Language language = Language.Russian);

        /// <summary>
        /// Get seller sells
        /// </summary>
        /// <param name="productIds">Product ids</param>
        /// <param name="start">Sells from</param>
        /// <param name="finish">Sells to</param>
        /// <param name="returns">0 - enable returns; 1 - exclude returns; 2 - only returns</param>
        /// <param name="rowsCount">count of rows per page</param>
        /// <param name="page">page number</param>
        /// <param name="sign">Signature (Completed SHA256 or SellerSecret)</param>
        /// <param name="calculateSign">Calculate signature (if sign == sellersecret)</param>
        /// <returns></returns>
        Task<Interfaces.SellerSells.ISellerSells> GetSells(List<int> productIds, DateTime start, DateTime finish,
            int returns, int rowsCount, int page, string sign, bool calculateSign = true);
    }
}
