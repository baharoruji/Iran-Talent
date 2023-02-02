using IranTalent.Application.Interfaces.Contexts;
using IranTalent.Application.Services.Users.Queries.GetRoles;
using IranTalent.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Application.Services.Resumes.Queries.GetEmploymentType
{
    public class GetEmploymentTypeService
    {
        private readonly IDataBaseContext _context;

        public GetEmploymentTypeService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<EmploymentTypeDto>> Execute()
        {
            var types = _context.EmploymentTypes.ToList().Select(p => new EmploymentTypeDto
            {
                Id = p.Id,
                Name = p.Name
            }).ToList();

            return new ResultDto<List<EmploymentTypeDto>>()
            {
                Data = types,
                IsSuccess = true,
                Message = "",
            };
        }
    }
}
