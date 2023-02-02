using IranTalent.Application.Interfaces.Contexts;
using IranTalent.Application.Services.Products.Commands.AddNewJob;
using IranTalent.Common.Dto;
using IranTalent.Domain.Entities.Jobs;
using IranTalent.Domain.Entities.Resumes;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Application.Services.Resumes.Commands.AddNewResume
{
    public class AddNewResumeService
    {
        private readonly IDataBaseContext _context;
        //private readonly IHostingEnvironment _environment;

        public AddNewResumeService(IDataBaseContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            //_environment = hostingEnvironment;
        }


        public ResultDto Execute(RequestAddNewResumeDto request)
        {
            try
            {

                var category = _context.Categories.Find(request.CategoryId);

                Resume resume = new Resume()
                {
                     UserId = request.UserId, 
                     Number = request.Number,
                     salary = request.salary,
                     Address = request.Address,
                    Category = category,

                };
                _context.Resumes.Add(resume);

                //var uploadedResult = UploadFile(request.UserImage);
                //UserImage userimage = new UserImage
                //{
                //    Resume = resume,
                //    Src = uploadedResult.FileNameAddress,
                //};
                //_context.UserImages.Add(userimage);


                List<UserSkills> userSkills = new List<UserSkills>();
                foreach (var item in request.Skills)
                {
                    userSkills.Add(new UserSkills
                    {
                        DisplayName = item.DisplayName,
                        Value = item.Value,
                        Resume = resume,
                    });
                }
                _context.UserSkills.AddRange(userSkills);

                List<WorkBackground> works = new List<WorkBackground>();
                foreach (var item in request.Works)
                {
                    works.Add(new WorkBackground
                    {
                        DisplayName = item.DisplayName,
                        Value = item.Value,
                        Resume = resume,
                    });
                }
                _context.WorkBackgrounds.AddRange(works);

                List<EducationSkills> education  = new List<EducationSkills>();
                foreach (var item in request.Educations)
                {
                    education.Add(new EducationSkills
                    {
                        DisplayName = item.DisplayName,
                        Value = item.Value,
                        Resume = resume,
                    });
                }
                _context.EducationSkills.AddRange(education);

                _context.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "رزومه با موفقیت ثبت شد",
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

        //private UploadDto UploadFile(IFormFile file)
        //{
        //    if (file != null)
        //    {
        //        string folder = $@"images\ProductImages\";
        //        var uploadsRootFolder = Path.Combine(_environment.WebRootPath, folder);
        //        if (!Directory.Exists(uploadsRootFolder))
        //        {
        //            Directory.CreateDirectory(uploadsRootFolder);
        //        }


        //        if (file == null || file.Length == 0)
        //        {
        //            return new UploadDto()
        //            {
        //                Status = false,
        //                FileNameAddress = "",
        //            };
        //        }

        //        string fileName = DateTime.Now.Ticks.ToString() + file.FileName;
        //        var filePath = Path.Combine(uploadsRootFolder, fileName);
        //        using (var fileStream = new FileStream(filePath, FileMode.Create))
        //        {
        //            file.CopyTo(fileStream);
        //        }

        //        return new UploadDto()
        //        {
        //            FileNameAddress = folder + fileName,
        //            Status = true,
        //        };
        //    }
        //    return null;
        //}
    }
}
