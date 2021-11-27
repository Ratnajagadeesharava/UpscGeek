using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UpscGeek.Core.Entities;
using UpscGeek.Infrastructure.Repositories.Base;

namespace UpscGeek.Infrastructure.Repositories
{
    public class SubjectRepository:Repository<Subject>
    {
        public Task<IEnumerable<Subject>> GetSubjects()
        {
            return base.GetAllAsync("Subjects");
        }
        
    }
}