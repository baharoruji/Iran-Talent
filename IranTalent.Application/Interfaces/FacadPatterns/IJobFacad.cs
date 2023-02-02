using IranTalent.Application.Services.Products.Commands.AddNewCategory;
using IranTalent.Application.Services.Products.Commands.AddNewJob;
using IranTalent.Application.Services.Products.Queries.GetAllCategories;
using IranTalent.Application.Services.Products.Queries.GetCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Application.Interfaces.FacadPatterns
{
    public interface IJobFacad
    {
        AddNewCategoryService AddNewCategoryService { get; }
        IGetCategoriesService GetCategoriesService { get; }
        AddNewJobService AddNewJobService { get; }
        IGetAllCategoriesService GetAllCategoriesService { get; }
    }
}
