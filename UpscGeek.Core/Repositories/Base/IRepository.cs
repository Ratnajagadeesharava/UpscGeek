using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpscGeek.Core.Repositories.Base
{
    public interface IRepository<T> where  T: class
    {
        Task<IEnumerable<T>> GetAllAsync(string databaseName);
        Task<T> GetByIdAsync(int id,string colllectionName);
        Task<T> AddAsync(T entity,string databaseName);
        Task DeleteAsync(T entity,string databaseName);
        Task<T> UpdateAsync(T entity,string databaseName);
    }
}