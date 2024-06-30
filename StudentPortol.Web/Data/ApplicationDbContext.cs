using Microsoft.EntityFrameworkCore;
using StudentPortol.Web.Models.Entities;

namespace StudentPortol.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Student> Students{ get; set; }
    }
}
