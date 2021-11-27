using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UpscGeek.Core.Entities;
using UpscGeek.Core.Repositories;
using UpscGeek.Core.Repositories.Base;

namespace UpscGeek.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        // GET: api/Subject
        private IRepository<Subject> _subjectRepository;
        public SubjectController(IRepository<Subject> subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Subject>> Get()
        {
            return await this._subjectRepository.GetAllAsync("Subjects");
        }

        // GET: api/Subject/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Subject
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Subject/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Subject/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
