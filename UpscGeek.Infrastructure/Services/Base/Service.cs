using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using MongoDB.Driver;
using UpscGeek.Core.Services.Base;

namespace UpscGeek.Infrastructure.Services.Base
{
    public class Service<T>: IService<T> where T:class
    {
        private  Subject<T> _allresultSubject = new Subject<T>();
        public IObservable<T> AllResult { get; set; }
        private readonly HttpClient _httpClient;
        public Service(HttpClient httpClient)
        {
            this.AllResult = this._allresultSubject.AsObservable();
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<T>> GetAllAsync(string urlEndPoint)
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<T>>(urlEndPoint);
            return result;
        }
    }
}