using AspNetCoreCRUDtestv1.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreCRUDtestv1.Data
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
