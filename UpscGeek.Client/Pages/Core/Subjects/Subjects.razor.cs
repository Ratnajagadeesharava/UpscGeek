using System.Collections.Generic;

namespace UpscGeek.Client.Pages.Core.Subjects
{
    public partial class Subjects
    {
        private Dictionary<string, List<string>> hashMap = new Dictionary<string, List<string>>();

        public Subjects()
        {
            this.hashMap.Add("GS-I",new List<string>(){"Art& Culture","Modern History","World History","Geogrpahy of India & World","Human Geography","Indian Society"});
                this.hashMap.Add("GS-II",new List<string>(){"Polity","Governance","Consitution","Social Justice","International Relations"});
                this.hashMap.Add("GS-III",new List<string>(){"Technology","Economic Development","Biodiversity","Environment","Security","Disaster Management"});
                this.hashMap.Add("GS-IV",new List<string>(){"Ethics","Integrity","Aptitude"});
        }
    }

   
}