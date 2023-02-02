using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Application.Services.Products.Commands.AddNewJob
{
    public class RequestAddNewJobDto
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string Salary { get; set; }
        public long CategoryId { get; set; }
        public bool Displayed { get; set; }
        public IFormFile Image { get; set; }
        public List<AddNewJob_Skills> Skills { get; set; }
    }
}
