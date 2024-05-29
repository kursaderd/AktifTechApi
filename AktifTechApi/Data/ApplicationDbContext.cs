using AktifTechApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AktifTechApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<UserLoginModel> Users { get; set; }
        public DbSet<CourseModel> Courses { get; set; }
        public DbSet<UsersCourseModel> UsersCourses { get; set; }
    } 
    
}
