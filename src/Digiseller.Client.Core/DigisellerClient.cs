using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Digiseller.Client.Core.Enums;
using Digiseller.Client.Core.Exceptions;
using Digiseller.Client.Core.Interfaces;
using Digiseller.Client.Core.Models.CategoryProducts;
using Digiseller.Client.Core.Serializers;
using Digiseller.Client.Core.ViewModels;

namespace Digiseller.Client.Core
{
    /// <summary>
    /// Digiseller Client
    /// </summary>
    public class DigisellerClient : IDigisellerClient
    {
        private readonly HttpClient _httpClient;

        #region Digiseller URLs API
        private const string UrlGetCategoryList = "xml/shop_categories.asp";
        private const string UrlGetCategoryGoodsList = "xml/shop_products.asp";
        private const string UrlGetFullProductInformation = "xml/shop_product_info.asp";
        private const string UrlGetProductReviews = "xml/shop_reviews.asp";
        private const string UrlGetSellerGoods = "https://api.digiseller.ru/api/seller-goods";
        private const string UrlGetProductDiscount = "xml/shop_discount.asp";
        private const string UrlGetGoodstBySearchString = "xml/shop_search.asp";
        private const string UrlGetTopTwentySale = "xml/shop_last_sales.asp";
        private const string UrlAddToCart = "xml/shop_cart_add.asp";
        private const string UrlUpdateCart = "xml/shop_cart_lst.asp";
        #endregion

        /// <summary>
        /// Constructor Digiseller Client
        /// </summary>
        /// <param name="sellerId">Seller Idenfiticator</param>
        /// <param name="sellerUid">Seller unique Identificator</param>
        public DigisellerClient(uint sellerId, string sellerUid)
        {
            SellerId = sellerId;
            SellerUid = sellerUid;
            _httpClient = new HttpClient { BaseAddress = new Uri("http://shop.digiseller.ru/") };
        }

        

        /// <summary>
        /// Identificator of seller from digiseller system
        /// </summary>
        public uint SellerId { get; set; }

        /// <summary>
        /// Unique identificator of seller from digiseller system
        /// </summary>
        public string SellerUid { get; set; }

        private readonly Dictionary<Language, string> _languages = new Dictionary<Language, string>
        {
            {Language.Russian, "ru-RU"},
            {Language.English, "en-US"}
        };

        private async Task<TResponse> GetDigisellerDataAsync<TRequest, TResponse>(TRequest requestObject,
            ISerializer<TRequest, TResponse> serializer, string requestUrl) where TResponse : class
        {
            var request = await serializer.Serialize(requestObject);
            var responseMessage = await _httpClient.PostAsync(requestUrl, request);

            if(!responseMessage.IsSuccessStatusCode)
                throw new DigisellerException($"Digiseller was unable to process the request. HTTP Status code: {responseMessage.StatusCode}");


            var responseData = await responseMessage.Content.ReadAsStringAsync(); // Get data
            var responseObject = await serializer.Deserialize(responseData); // Get object

            if (!(responseObject is IDigisellerResponse)) // if object can't be brought to the interface
                throw new DigisellerException("I can't bring the object to the Digiseller response. Support for this developer");

            var digiResponse = responseObject as IDigisellerResponse;

            if (digiResponse.HasErrors()) // If digiseller system send error
                throw new DigisellerException(
                    $"The request was not processed. Digiseller's system indicated the error. Request code: {digiResponse.ErrorCode}, message: {digiResponse.ErrorMessage}");

            return responseObject;
        }

        /// <summary>
        /// Get categories with current sellerid
        /// </summary>
        /// <param name="rootCategory">Root category
        /// 0 - All categories</param>
        /// <param name="language">Language</param>
        /// <returns></returns>
        public async Task<IEnumerable<Interfaces.Categories.ICategory>> GetCategoriesAsync(int rootCategory = 0, Language language = Language.Russian)
        {
            var request = new Models.Categories.CategoriesRequest(SellerId, rootCategory, _languages[language]);
            var response =
                await GetDigisellerDataAsync(request, new XmlSerializer<Models.Categories.CategoriesRequest, Models.Categories.CategoriesResponse>(),
                    UrlGetCategoryList);

            return response?.Categories?.Category?.Select(p => new Category(p));
        }

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
        public async Task<Interfaces.CategoryProducts.IProductRepository> GetCategoryGoodsAsync(int categoryId = 0,
            Language language = Language.Russian,
            int pageNumber = 1, int countGoods = 20, Currency currency = Currency.RUR, Sorting sorting = Sorting.name)
        {
            var request = new CategoryProductsRequest(SellerId, categoryId, _languages[language], pageNumber, countGoods,
                currency, sorting);
            var response =
                await GetDigisellerDataAsync(request, new XmlSerializer<CategoryProductsRequest, CategoryProductsResponse>(),
                    UrlGetCategoryGoodsList);

            return response != null ? new ViewModels.CategoryProducts.ProductRepository(response) : null;
        }

        /// <summary>
        /// Get full product information
        /// </summary>
        /// <param name="productId">Product Id</param>
        /// <param name="language">Language information</param>
        /// <returns></returns>
        public async Task<Interfaces.ProductInformation.IProduct> GetProductAsync(int productId, Language language = Language.Russian)
        {
            var request = new Models.ProductInformation.ProductInformationRequest(SellerId, productId, SellerUid, _languages[language]);
            var response =
                await GetDigisellerDataAsync(request, new XmlSerializer<Models.ProductInformation.ProductInformationRequest, Models.ProductInformation.ProductInformationResponse>(),
                    UrlGetFullProductInformation);

            return response.Product != null ? new ViewModels.ProductInformation.ProductInformation(response.Product) : null;
        }

        /// <summary>
        /// Get product reviews
        /// </summary>
        /// <param name="productId">Product id</param>
        /// <param name="reviewType">Type of reviews</param>
        /// <param name="pageNumber">Page number (pagination)</param>
        /// <param name="rowsCount">Count of reviews per page</param>
        /// <returns></returns>
        public async Task<Interfaces.ProductReviews.IProductReviews> GetProductReviews(int productId, ReviewType reviewType = ReviewType.All, int pageNumber = 1, int rowsCount = 20)
        {
            var request = new Models.ProductReviews.ProductReviewsRequest(SellerId, productId, pageNumber, rowsCount, reviewType);
            var response =
                await GetDigisellerDataAsync(request, new XmlSerializer<Models.ProductReviews.ProductReviewsRequest, Models.ProductReviews.ProductReviewsResponse>(),
                    UrlGetProductReviews);

            return response != null ? new ViewModels.ProductReviews.ProductReviews(response) : null;
        }

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
        public async Task<Interfaces.SellerProducts.ISellerProducts> GetSellerProducts(int pageNumber = 1, int rowsCount = 20, Currency currency = Currency.RUR,
            OrderColumn orderColumn = OrderColumn.Name, OrderDir orderDir = OrderDir.Asc,
            Language language = Language.Russian)
        {
            return await GetSellerProducts(SellerId, pageNumber, rowsCount, currency, orderColumn, orderDir, language);
        }


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
        public async Task<Interfaces.SellerProducts.ISellerProducts> GetSellerProducts(uint sellerId, int pageNumber = 1, int rowsCount = 20, Currency currency = Currency.RUR,
            OrderColumn orderColumn = OrderColumn.Name, OrderDir orderDir = OrderDir.Asc,
            Language language = Language.Russian)
        {
            var request = new Models.SellerProducts.SellerProductsRequest(sellerId, orderColumn.ToString().ToLower(), orderDir.ToString().ToLower(), rowsCount, pageNumber,
                currency.ToString(), _languages[language]);

            var response =
                await GetDigisellerDataAsync(request, new XmlSerializer<Models.SellerProducts.SellerProductsRequest, Models.SellerProducts.SellerProductsResponse>(),
                    UrlGetSellerGoods);

            return response != null ? new ViewModels.SellerProducts.SellerProducts(response) : null;
        }

        /// <summary>
        /// Get product discount by buyer email
        /// </summary>
        /// <param name="productId">Product Id</param>
        /// <param name="email">Buyer email</param>
        /// <param name="currency">Currency</param>
        /// <returns></returns>
        public async Task<Interfaces.ProductDiscounts.IProductDiscount> GetProductDiscount(int productId, string email, Currency currency = Currency.RUR)
        {
            var request = new Models.ProductDiscounts.ProductDiscountRequest(productId, email, currency);
            var response =
                await GetDigisellerDataAsync(
                    request, new XmlSerializer<Models.ProductDiscounts.ProductDiscountRequest, Models.ProductDiscounts.ProductDiscountResponse>(), UrlGetProductDiscount);

            return response != null ? new ViewModels.ProductDiscounts.ProductDiscount(response) : null;
        }

        /// <summary>
        /// Get goods by search string
        /// </summary>
        /// <param name="searchString">Search string</param>
        /// <param name="pageNumber">Page number (pagination)</param>
        /// <param name="rowsCount">Count of goods per page</param>
        /// <param name="currency">Currency</param>
        /// <returns></returns>
        public async Task<Interfaces.ProductSearch.ISearchProduct> GetGoodsBySearchString(string searchString, int pageNumber = 1, int rowsCount = 10, Currency currency = Currency.RUR)
        {
            var request =
                new Models.ProductSearch.ProductSearchRequest(SellerId, searchString, currency.ToString(), pageNumber, rowsCount);
            var response =
                await GetDigisellerDataAsync(request, new XmlSerializer<Models.ProductSearch.ProductSearchRequest, Models.ProductSearch.ProductSearchResponse>(),
                    UrlGetGoodstBySearchString);

            return response != null ? new ViewModels.ProductSearch.SearchProduct(response) : null;

        }

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
        public async Task<Interfaces.Cart.ICartAdd> AddToCart(int productId, int productCount, string email, string cartUid = "", Currency currency = Currency.RUR, Language language = Language.Russian)
        {
            var request = new Models.Cart.Request.AddRequest(productId, productCount, currency, email, _languages[language], cartUid);
            var response =
                await GetDigisellerDataAsync(request,
                    new JsonSerializer<Models.Cart.Request.AddRequest, Models.Cart.Response.AddResponse>(), UrlAddToCart);
            return new ViewModels.Cart.AddCart(response);
        }

        /// <summary>
        /// Update cart
        /// </summary>
        /// <param name="cartUid">Cart UID</param>
        /// <param name="itemUpdate">item id for update (optional)</param>
        /// <param name="productCount">Product Count (optional, required if itemUpdate != null)</param>
        /// <param name="currency">Currency</param>
        /// <param name="language">Language information</param>
        /// <returns></returns>
        public async Task<Interfaces.Cart.ICartUpdate> UpdateCart(string cartUid, int? itemUpdate = null, int? productCount = null, Currency currency = Currency.RUR, Language language = Language.Russian)
        {
            if (itemUpdate != null && productCount == null)
                throw new NullReferenceException("Product count is required if you use item update!");

            var request = new Models.Cart.Request.UpdateRequest(cartUid, itemUpdate, productCount, currency.ToString(), _languages[language]);
            var response =
                await GetDigisellerDataAsync(request,
                    new JsonSerializer<Models.Cart.Request.UpdateRequest, Models.Cart.Response.UpdateResponse>(), UrlUpdateCart);
            return new ViewModels.Cart.CartUpdate(response);
        }
    }
}
