using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace RADIndividualTask.Models1
{
    public partial class Product : BaseModel
    {
        public Product()
        {
            OutputReports = new HashSet<OutputReport>();
        }

        public Product(string name, Dictionary<int, double> usedMaterials)
        {
            OutputReports = new HashSet<OutputReport>();
            
            Name = name;
            
            Materials = JsonSerializer.Serialize(usedMaterials);
        }

        public string Name { get; set; } = null!;
        public string Materials { get; set; } = null!;

        public virtual ICollection<OutputReport> OutputReports { get; set; }

        public Dictionary<int, double> GetMaterials()
        {
            var result = JsonSerializer.Deserialize<Dictionary<int, double>>(Materials);
            return result;
        }
    }
}
