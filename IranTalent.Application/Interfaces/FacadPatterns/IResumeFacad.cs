using IranTalent.Application.Services.Products.Commands.AddNewJob;
using IranTalent.Application.Services.Resumes.Commands.AddNewResume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Application.Interfaces.FacadPatterns
{
    public interface IResumeFacad
    {
        AddNewResumeService AddNewResumeService { get; }
    }
}
