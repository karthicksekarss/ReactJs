using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.DataBase
{
    public class EmployeeContext :  DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }


        public DbSet<Employee> Employees{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("EMPLOYEE");
        }
    }
}
