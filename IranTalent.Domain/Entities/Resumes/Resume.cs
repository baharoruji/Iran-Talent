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
    public class Resume : BaseEntity
    {
        public int UserId { get; set; }
        public string Number { get; set; }
        public string salary { get; set; }
        public string Address { get; set; }
        public virtual Category Category { get; set; }
        public long CategoryId { get; set; }
        public virtual UserImage UserImage { get; set; }
        public virtual ICollection<UserSkills> UserSkills { get; set; }
        public virtual ICollection<WorkBackground> WorkBackground { get; set; }
        public virtual ICollection<EducationSkills> EducationSkills { get; set; }
        public ICollection<SeniorityLevelInResume> SeniorityLevelInResumes { get; set; }
        public ICollection<EmploymentTypeInResume> EmploymentTypeInResumes { get; set; }

    }
}
