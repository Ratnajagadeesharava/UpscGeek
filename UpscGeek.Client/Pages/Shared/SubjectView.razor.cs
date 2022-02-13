using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using UpscGeek.Core.Entities;

namespace UpscGeek.Client.Pages.Shared
{
    public partial class SubjectView
    {
        [Parameter]
        public List<Subject> subjects { get; set; }
    }
}