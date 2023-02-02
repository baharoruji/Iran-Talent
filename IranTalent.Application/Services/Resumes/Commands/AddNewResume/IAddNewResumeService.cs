using IranTalent.Application.Services.Products.Commands.AddNewJob;
using IranTalent.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Application.Services.Resumes.Commands.AddNewResume
{
    public interface IAddNewResumeService
    {
        ResultDto Execute(RequestAddNewResumeDto request);
    }
}
