using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UpscGeek.Core.Entities;
using UpscGeek.Core.Repositories.Base;
using UpscGeek.Infrastructure.Data;
using UpscGeek.Infrastructure.Repositories.Base;

namespace UpscGeek.Infrastructure.Repositories
{
    public class SubjectRepository:IRepository<Subject>
    {
        private MainDbContext _dbContext;

        public SubjectRepository(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Subject>> GetAllAsync(string databaseName)
        {
             var result = await this._dbContext.Subjects.ToListAsync();
             return result;
        }

        public Task<Subject> GetByIdAsync(int id, string colllectionName)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Subject> AddAsync(Subject subject, string databaseName)
        {
            var result =  await this._dbContext.AddAsync(subject);
            return result.Entity;
        }

        public Task DeleteAsync(Subject entity, string databaseName)
        {
            throw new System.NotImplementedException();
        }

        public Task<Subject> UpdateAsync(Subject entity, string databaseName)
        {
            throw new System.NotImplementedException();
        }
    }
}