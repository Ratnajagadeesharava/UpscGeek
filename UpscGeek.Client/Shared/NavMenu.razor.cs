
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UpscGeek.Infrastructure.FacadeServices;

namespace UpscGeek.Client.Shared
{
    public partial class NavMenu
    {
        public bool isActive = false;
        [Inject] public SampleService _Sample { get; set; }

        protected override async Task OnInitializedAsync()
        {
            _Sample.Obs.Subscribe((x =>
            {
                OnClick();
            }));
        }

        public void OnClick()
        {
            this.isActive = !this.isActive;
            Console.Write(this.isActive);
            
        }
    }
}