using IranTalent.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Domain.Entities.Jobs
{
    public class Job : BaseEntity
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string salary { get; set; }
        public bool Displayed { get; set; }
        public virtual Category Category { get; set; }
        public long CategoryId { get; set; }
        public virtual JobImage JobImage { get; set; }
        public virtual ICollection<JobSkills> JobSkills { get; set; }
    }
}
