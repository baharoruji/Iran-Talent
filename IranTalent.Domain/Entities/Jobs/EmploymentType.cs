using IranTalent.Domain.Entities.Commons;
using IranTalent.Domain.Entities.Resumes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Domain.Entities.Jobs
{
    public class EmploymentType : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<EmploymentTypeInResume> employmentTypeInResumes { get; set; }
    }
}
