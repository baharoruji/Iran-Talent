using IranTalent.Domain.Entities.Jobs;
using IranTalent.Domain.Entities.Resumes;
using IranTalent.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace IranTalent.Application.Interfaces.Contexts
{
    public interface IDataBaseContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<UserInRole> UserInRoles { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Job> Jobs { get; set; }
        DbSet<JobImage> JobImages { get; set; }
        DbSet<JobSkills> JobSkills { get; set; }
        DbSet<EducationSkills> EducationSkills { get; set; }
        DbSet<Resume> Resumes { get; set; }
        DbSet<UserImage> UserImages { get; set; }
        DbSet<UserSkills> UserSkills { get; set; }
        DbSet<WorkBackground> WorkBackgrounds { get; set; }
        DbSet<SeniorityLevel> SeniorityLevels { get; set; }
        DbSet<SeniorityLevelInResume> SeniorityLevelInResumes { get; set; }
        DbSet<EmploymentType> EmploymentTypes { get; set; }
        DbSet<EmploymentTypeInResume> EmploymentTypeInResumes { get; set; }


        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());

    }
}
