using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UpscGeek.Core.Entities;
using UpscGeek.Core.Services.Base;

namespace UpscGeek.Client.Pages.Core.Subjects
{
    public partial class Subjects
    {
        public List<Subject> subjects = new List<Subject>();
        [Inject]
        public IService<Subject> _Service { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            this.subjects = (await _Service.GetAllAsync("api/subject")).ToList();
        }
    }

   
}