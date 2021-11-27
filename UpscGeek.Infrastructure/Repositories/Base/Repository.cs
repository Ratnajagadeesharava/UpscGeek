using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using UpscGeek.Core.Entities;
using UpscGeek.Core.Repositories.Base;

namespace UpscGeek.Infrastructure.Repositories.Base
{
    public class Repository<T>  :IRepository<T> where T:class
    {

        private readonly IMongoDatabase _database;
        public Repository()
        {
            MongoClient client = new MongoClient(
                "mongodb+srv://jagadeesh:jagadeesh4987@upscgeekcluster.qe0ax.mongodb.net/UpscGeek?retryWrites=true&w=majority");
          _database = client.GetDatabase("UpscGeek");
          
        }
        public async Task<IEnumerable<T>> GetAllAsync(string collectionName)
        {
            IMongoCollection<T> collection = _database.GetCollection<T>(collectionName);
            return await collection.FindAsync(item => true).Result.ToListAsync();
        }

        public Task<T> GetByIdAsync(int id,string colllectionName)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> AddAsync(T entity,string databaseName)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(T entity,string databaseName)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity, string databaseName)
        {
            throw new System.NotImplementedException();
        }
    }
}