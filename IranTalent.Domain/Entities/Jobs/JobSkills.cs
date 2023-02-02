using IranTalent.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Domain.Entities.Jobs
{
    public class JobSkills : BaseEntity
    {
        public virtual Job job { get; set; }
        public long jobId { get; set; }
        public string DisplayName { get; set; }
        public string Value { get; set; }
    }
}

