using IranTalent.Application.Services.Products.Commands.AddNewJob;
using IranTalent.Domain.Entities.Jobs;
using IranTalent.Domain.Entities.Resumes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Application.Services.Resumes.Commands.AddNewResume
{
    public class RequestAddNewResumeDto
    {
        public int UserId { get; set; }
        public string Number { get; set; }
        public string salary { get; set; }
        public string Address { get; set; }
        public long CategoryId { get; set; }
        public IFormFile UserImage { get; set; }
        public ICollection<SeniorityLevelInResume> SeniorityLevelInResumes { get; set; }
        public ICollection<EmploymentTypeInResume> EmploymentTypeInResumes { get; set; }
        public List<AddNewResume_Skills> Skills { get; set; }
        public List<AddNewResume_Education> Educations { get; set; }
        public List<AddNewResume_Work> Works { get; set; }
    }
}
