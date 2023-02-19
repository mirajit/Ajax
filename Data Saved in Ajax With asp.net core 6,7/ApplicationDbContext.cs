using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebEmployee.Models;

namespace WebEmployee.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<EmployeeModel> Employee { get; set; }
        public virtual DbSet<Jsondatamodel> Jasondata { get; set; }

    }
}