using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;

namespace StudentManagement.DbContexts
{
    public class StudentManagementDbContext : DbContext
    {
        public StudentManagementDbContext(DbContextOptions<StudentManagementDbContext> option) : base(option) { }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(s => s.SId);
        }

    }
}
