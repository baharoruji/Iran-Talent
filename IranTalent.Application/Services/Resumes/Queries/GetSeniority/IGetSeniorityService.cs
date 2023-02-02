using IranTalent.Application.Services.Users.Queries.GetRoles;
using IranTalent.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Application.Services.Resumes.Queries.GetSeniority
{
    public interface IGetSeniorityService
    {
        ResultDto<List<SeniorityDto>> Execute();
    }
}
