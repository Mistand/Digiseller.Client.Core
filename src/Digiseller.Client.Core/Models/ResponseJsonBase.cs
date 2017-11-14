using System.Xml.Serialization;
using Digiseller.Client.Core.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Digiseller.Client.Core.Models
{
    public abstract class ResponseJsonBase : IDigisellerResponse
    {
        [JsonProperty(PropertyName = "cart_err")]
        public int ErrorCode { get; }

        public bool HasErrors()
        {
            return ErrorCode != 0;
        }

        public string ErrorMessage
        {
            get
            {
                switch (ErrorCode)
                {
                    case 0:
                        return "Запрос выполнен";
                    case -1:
                        return "Не указан один из параметров запроса";
                    case 2:
                        return "Превышено максимальное количество товаров в корзине - 50";
                    case 3:
                        return "Слишком много корзин открыто за последний час с этого IP адреса";
                    case 4:
                        return "Указанная корзина не найдена";
                    case 5:
                        return "Товар нельзя оплатить указанным способом/валютой";
                    case 8:
                        return "В корзине обнаружены товары продавцов, принимающих средства напрямую на свой кошелек";
                    case 101:
                    case 102:
                        return "Оплата товара временно недоступна";
                    case 103:
                        return "Неизвестная ошибка";
                    default:
                        return "Неизвестная ошибка (Не найдена информация по данному коду ошибки)";
                }
            }
        }
    }
}
