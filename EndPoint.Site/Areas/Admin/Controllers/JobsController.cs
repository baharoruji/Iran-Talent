using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IranTalent.Application.Interfaces.FacadPatterns;
using IranTalent.Application.Services.Products.Commands.AddNewJob;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobsController : Controller
    {

        private readonly IJobFacad _jobFacad;

        public JobsController(IJobFacad productFacad)
        {
            _jobFacad = productFacad;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNewJob()
        {
            ViewBag.Categories = new SelectList(_jobFacad.GetAllCategoriesService.Execute().Data,"Id" , "Name");
            return View();
        }

        [HttpPost]
        public IActionResult AddNewJob(RequestAddNewJobDto request, List<AddNewJob_Skills> Skills)
        {
            var file = Request.Form.Files[0];
            IFormFile image = file;
            request.Image = image;
            request.Skills = Skills;

            return Json(_jobFacad.AddNewJobService.Execute(request));
        }
    }
}
