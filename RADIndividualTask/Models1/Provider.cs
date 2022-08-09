using System;
using System.Collections.Generic;

namespace RADIndividualTask.Models1
{
    public partial class Provider : BaseModel
    {
        public double Loan { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Material> Materials { get; set; }
        
        public Provider()
        {
            Materials = new HashSet<Material>();
        }


        public Provider(string name)
        {
            Materials = new HashSet<Material>();
            
            Name = name;
            Loan = 0d;
        }

        public void UpdateLoan()
        {
            foreach (var material in Materials)
            {
                
            }
        }
    }
}
