using IranTalent.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Domain.Entities.Resumes
{
    public class WorkBackground : BaseEntity
    {
        public virtual Resume Resume { get; set; }
        public long ResumeId { get; set; }
        public string DisplayName { get; set; }
        public string Value { get; set; }
    }
}
