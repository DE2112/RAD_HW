using System;
using System.Collections.Generic;
using RADIndividualTask.Models1;

namespace RADIndividualTask.Models1
{
    public partial class Material : BaseModel
    {
        public Material()
        {
            InputReports = new HashSet<InputReport>();
        }
        
        public Material(string name, int providerId)
        {
            InputReports = new HashSet<InputReport>();
            
            Name = name;
            ProviderId = providerId;
            Provider = CRUD.Context.Providers.Find(ProviderId);
            Provider.Materials.Add(this);
        }

        public int ProviderId { get; set; }
        public string Name { get; set; }

        public virtual Provider Provider { get; set; } = null!;
        public virtual ICollection<InputReport> InputReports { get; set; }
    }
}
