using IranTalent.Application.Interfaces.FacadPatterns;
using IranTalent.Application.Services.Resumes.Commands.AddNewResume;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EndPoint.Site.Controllers
{
    public class ResumeController : Controller
    {
        private readonly IResumeFacad _ResumeFacad;
        private readonly IJobFacad _JobFacad;

        public ResumeController(IResumeFacad ResumeFacad, IJobFacad jobFacad)
        {
            _ResumeFacad = ResumeFacad;
            _JobFacad = jobFacad;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNewResume()
        {
            ViewBag.Categories = new SelectList(_JobFacad.GetAllCategoriesService.Execute().Data, "Id", "Name");
            //ViewBad.Seniority = new SelectList(_ResumeFacad.get)
            //ViewBag.EmploymentType = 
            return View();
        }

        [HttpPost]
        public IActionResult AddNewResume(RequestAddNewResumeDto request, List<AddNewResume_Skills> Skills, List<AddNewResume_Education> education, List<AddNewResume_Work> work)
        {
            var file = Request.Form.Files[0];
            IFormFile image = file;
            request.UserImage = image;
            request.Skills = Skills;
            request.Works = work;
            request.Educations = education;

            return Json(_ResumeFacad.AddNewResumeService.Execute(request));
        }
    }



}
