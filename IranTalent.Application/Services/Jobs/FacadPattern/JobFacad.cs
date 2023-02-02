using IranTalent.Application.Interfaces.Contexts;
using IranTalent.Application.Interfaces.FacadPatterns;
using IranTalent.Application.Services.Products.Commands.AddNewCategory;
using IranTalent.Application.Services.Products.Commands.AddNewJob;
using IranTalent.Application.Services.Products.Queries.GetAllCategories;
using IranTalent.Application.Services.Products.Queries.GetCategories;
using Microsoft.AspNetCore.Hosting;

namespace IranTalent.Application.Services.Products.FacadPattern
{
    public class JobFacad : IJobFacad
    {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;
        public JobFacad(IDataBaseContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _environment = hostingEnvironment;

        }

        private AddNewCategoryService _addNewCategory;
        public AddNewCategoryService AddNewCategoryService
        {
            get
            {
                return _addNewCategory = _addNewCategory ?? new AddNewCategoryService(_context);
            }
        }


        private IGetCategoriesService _getCategoriesService;
        public IGetCategoriesService GetCategoriesService
        {
            get
            {
                return _getCategoriesService = _getCategoriesService ?? new GetCategoriesService(_context);
            }
        }

        private AddNewJobService _addNewJobService;
        public AddNewJobService AddNewJobService
        {
            get
            {
                return _addNewJobService = _addNewJobService ?? new AddNewJobService(_context, _environment);
            }
        }

        private IGetAllCategoriesService _getAllCategoriesService;
        public IGetAllCategoriesService GetAllCategoriesService
        {
            get
            {
                return _getAllCategoriesService = _getAllCategoriesService ?? new GetAllCategoriesService(_context);
            }
        }
    }
}
