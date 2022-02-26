using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UpscGeek.Core.Entities;
using UpscGeek.Core.Entities.Enum;
using UpscGeek.Core.Services.Base;
using UpscGeek.Infrastructure.FacadeServices;
using UpscGeek.Infrastructure.Services.Base;

namespace UpscGeek.Client.Pages.Core.Subjects
{
    public partial class Subjects
    {
        public string subject = "all";
        public List<Subject> FilteredSubjects = new List<Subject>();
        public List<Subject> subjects = new List<Subject>();
        [Inject]
        public IService<Subject> _Service { get; set; }
        public ISet<Papers> set { get; set; }
        [Inject] public SampleService _Sample { get; set; }
        protected override async Task OnInitializedAsync()
        {
            set = new HashSet<Papers>();
            this.subjects = (await this._Service.GetAllAsync("/api/subject")).ToList();
            this.subjects.ForEach(subject => set.Add(subject.Paper));
            this.FilteredSubjects = subjects;

        }

        private void FilterSubject(Papers papers)
        {
            this.FilteredSubjects = this.subjects.FindAll((subject => subject.Paper == papers));
        }

    }

   
}