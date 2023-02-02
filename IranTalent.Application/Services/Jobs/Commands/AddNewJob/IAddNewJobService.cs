using IranTalent.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Application.Services.Products.Commands.AddNewJob
{
    public interface IAddNewJobService
    {
        ResultDto Execute(RequestAddNewJobDto request);
    }
}
