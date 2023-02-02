using IranTalent.Application.Interfaces.Contexts;
using IranTalent.Common.EmploymentType;
using IranTalent.Common.Roles;
using IranTalent.Common.SeniorityLevel;
using IranTalent.Domain.Entities.Jobs;
using IranTalent.Domain.Entities.Resumes;
using IranTalent.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;


namespace IranTalent.Persistence.Contexts
{
    public class DataBaseContext : DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobImage> JobImages { get; set; }
        public DbSet<JobSkills> JobSkills { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<SeniorityLevel> SeniorityLevels { get; set; }
        public DbSet<EducationSkills> EducationSkills { get; set; }
        public DbSet<EmploymentTypeInResume> EmploymentTypeInResumes { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<SeniorityLevelInResume> SeniorityLevelInResumes { get; set; }
        public DbSet<UserImage> UserImages { get; set; }
        public DbSet<UserSkills> UserSkills { get; set; }
        public DbSet<WorkBackground> WorkBackgrounds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed Data
            SeedData(modelBuilder);
            // اعمال ایندکس بر روی فیلد ایمیل
            // اعمال عدم تکراری بودن ایمیل
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            //-- عدم نمایش اطلاعات حذف شده
            ApplyQueryFilter(modelBuilder);
        }
 
        private void ApplyQueryFilter(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Role>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<UserInRole>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Category>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Job>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<JobSkills>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<JobImage>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Resume>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<EducationSkills>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<EmploymentType>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<SeniorityLevel>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<WorkBackground>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<UserImage>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<UserSkills>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<EmploymentTypeInResume>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<SeniorityLevelInResume>().HasQueryFilter(p => !p.IsRemoved);


        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role { Id = 1, Name = nameof(UserRoles.Admin) });
            modelBuilder.Entity<Role>().HasData(new Role { Id = 2, Name = nameof(UserRoles.Operator) });
            modelBuilder.Entity<Role>().HasData(new Role { Id = 3, Name = nameof(UserRoles.Customer) });

            modelBuilder.Entity<EmploymentType>().HasData(new EmploymentType { Id = 1, Name = nameof(UserEmploymentType.FullTime) });
            modelBuilder.Entity<EmploymentType>().HasData(new EmploymentType { Id = 2, Name = nameof(UserEmploymentType.PartTime) });
            modelBuilder.Entity<EmploymentType>().HasData(new EmploymentType { Id = 3, Name = nameof(UserEmploymentType.InternShip) });
            modelBuilder.Entity<EmploymentType>().HasData(new EmploymentType { Id = 4, Name = nameof(UserEmploymentType.Freelance) });

            modelBuilder.Entity<SeniorityLevel>().HasData(new SeniorityLevel { Id = 1, Name = nameof(UserSeniorityLevel.Lead) });
            modelBuilder.Entity<SeniorityLevel>().HasData(new SeniorityLevel { Id = 2, Name = nameof(UserSeniorityLevel.Senior) });
            modelBuilder.Entity<SeniorityLevel>().HasData(new SeniorityLevel { Id = 3, Name = nameof(UserSeniorityLevel.Junior) });
            modelBuilder.Entity<SeniorityLevel>().HasData(new SeniorityLevel { Id = 4, Name = nameof(UserSeniorityLevel.Intern) });

        }

    }
}
