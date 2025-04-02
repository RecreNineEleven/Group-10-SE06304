using Information_Management_System.model;
using Microsoft.EntityFrameworkCore;

namespace Information_Management_System.Data
{
    public class ApplicationDbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    }
}
