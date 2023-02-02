using IranTalent.Application.Interfaces.Contexts;
using IranTalent.Application.Services.Users.Queries.GetRoles;
using IranTalent.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Application.Services.Resumes.Queries.GetSeniority
{
    public class GetSeniorityService : IGetSeniorityService
    {
        private readonly IDataBaseContext _context;

        public GetSeniorityService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<SeniorityDto>> Execute()
        {
            var seniorities = _context.SeniorityLevels.ToList().Select(p => new SeniorityDto
            {
                Id = p.Id,
                Name = p.Name
            }).ToList();

            return new ResultDto<List<SeniorityDto>>()
            {
                Data = seniorities,
                IsSuccess = true,
                Message = "",
            };
        }
    }
}
