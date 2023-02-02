using IranTalent.Domain.Entities.Commons;
using IranTalent.Domain.Entities.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Domain.Entities.Resumes
{
    public class EmploymentTypeInResume : BaseEntity
    {
        public long Id { get; set; }
        public virtual Resume Resume { get; set; }
        public long ResumeId { get; set; }

        public virtual EmploymentType EmploymentType { get; set; }
        public long TypeId { get; set; }
    }
}
