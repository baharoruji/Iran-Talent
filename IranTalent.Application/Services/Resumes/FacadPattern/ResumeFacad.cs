using IranTalent.Application.Interfaces.Contexts;
using IranTalent.Application.Interfaces.FacadPatterns;
using IranTalent.Application.Services.Resumes.Commands.AddNewResume;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Application.Services.Resumes.FacadPattern

    {
        public class ResumeFacad : IResumeFacad
        {
            private readonly IDataBaseContext _context;
            private readonly IHostingEnvironment _environment;
            public ResumeFacad(IDataBaseContext context, IHostingEnvironment hostingEnvironment)
            {
                _context = context;
                _environment = hostingEnvironment;

            }

            private AddNewResumeService _AddNewResumeService;
            public AddNewResumeService AddNewResumeService
            {
                get
                {
                    return _AddNewResumeService = _AddNewResumeService ?? new AddNewResumeService(_context, _environment);
                }
            }


        }
    }


