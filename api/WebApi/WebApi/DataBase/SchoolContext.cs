using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebApi.Model;

namespace WebApi.DataBase
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("Data Source=KARTHICK;Initial Catalog=TMS;user id=sa;password=p@ssw0rd")
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
