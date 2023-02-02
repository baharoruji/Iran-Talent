using IranTalent.Application.Interfaces.Contexts;
using IranTalent.Common.Dto;
using IranTalent.Domain.Entities.Jobs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Application.Services.Products.Commands.AddNewJob
{
    public class AddNewJobService : IAddNewJobService
    {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;

        public AddNewJobService(IDataBaseContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _environment = hostingEnvironment;
        }


        public ResultDto Execute(RequestAddNewJobDto request)
        {
            try
            {

                var category = _context.Categories.Find(request.CategoryId);

                Job job = new Job()
                {
                    Company = request.Company,
                    Description = request.Description,
                    Name = request.Name,
                    salary = request.Salary,
                    Category = category,
                    Displayed = request.Displayed,
                };
                _context.Jobs.Add(job);

                var uploadedResult = UploadFile(request.Image);
                JobImage jobimage = new JobImage
                {
                    job = job,
                    Src = uploadedResult.FileNameAddress,
                };
                _context.JobImages.Add(jobimage);


                List<JobSkills> jobskills = new List<JobSkills>();
                foreach (var item in request.Skills)
                {
                    jobskills.Add(new JobSkills
                    {
                        DisplayName = item.DisplayName,
                        Value = item.Value,
                        job = job,
                    });
                }
                _context.JobSkills.AddRange(jobskills);

                _context.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "آگهی شغلی با موفقیت اضافه شد",
                };
            }
            catch (Exception ex)
            {

                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "خطا رخ داد ",
                };
            }

        }

        private UploadDto UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string folder = $@"images\ProductImages\";
                var uploadsRootFolder = Path.Combine(_environment.WebRootPath, folder);
                if (!Directory.Exists(uploadsRootFolder))
                {
                    Directory.CreateDirectory(uploadsRootFolder);
                }


                if (file == null || file.Length == 0)
                {
                    return new UploadDto()
                    {
                        Status = false,
                        FileNameAddress = "",
                    };
                }

                string fileName = DateTime.Now.Ticks.ToString() + file.FileName;
                var filePath = Path.Combine(uploadsRootFolder, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                return new UploadDto()
                {
                    FileNameAddress = folder + fileName,
                    Status = true,
                };
            }
            return null;
        }
    }
}
