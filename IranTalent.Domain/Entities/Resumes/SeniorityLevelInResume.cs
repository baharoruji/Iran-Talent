using IranTalent.Domain.Entities.Commons;
using IranTalent.Domain.Entities.Jobs;
using IranTalent.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Domain.Entities.Resumes
{
    public class SeniorityLevelInResume : BaseEntity
    {
        public long Id { get; set; }
        public virtual Resume Resume { get; set; }
        public long ResumeId { get; set; }

        public virtual SeniorityLevel SeniorityLevel { get; set; }
        public long seniorityId { get; set; }
    }
}
