using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MongoDB.Driver;
using UpscGeek.Core.Services.Base;

namespace UpscGeek.Infrastructure.Services.Base
{
    public class Service<T>: IService<T> where T:class
    {
        private HttpClient _httpClient;
        public Service(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<T>> GetAllAsync(string urlEndPoint)
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<T>>(urlEndPoint);
            return result;
        }
    }
}