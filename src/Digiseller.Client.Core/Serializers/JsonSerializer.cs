﻿using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Digiseller.Client.Core.Interfaces;
using Newtonsoft.Json;

namespace Digiseller.Client.Core.Serializers
{
    public class JsonSerializer<TRequest, TResponse> : ISerializer<TRequest, TResponse>
    {
        private IDictionary<string, string> GetValues(object obj)
        {
            var json = obj
                .GetType()
                .GetProperties()
                .Where(p => !string.IsNullOrEmpty(p.GetValue(obj).ToString()))
                .ToDictionary(p => p.Name, p => p.GetValue(obj).ToString());
            return json;
        }

        public Task<HttpContent> Serialize(TRequest obj)
        {
            return Task.Run(() => new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json") as HttpContent);
        }

        public Task<TResponse> Deserialize(string data)
        {
            return Task.Run(() => JsonConvert.DeserializeObject<TResponse>(data));
        }
    }
}