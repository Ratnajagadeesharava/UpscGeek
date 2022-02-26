using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UpscGeek.Core.Services.Base
{
    public interface IService<T> where  T: class
    {
        Task<IEnumerable<T>> GetAllAsync(string urlendpoint);
    }
}