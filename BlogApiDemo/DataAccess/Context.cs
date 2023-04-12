using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccess
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=HAN; database = CoreBlogApiDb; integrated security = true;");              
        }

        public DbSet<Employee> employees { get; set; }

    }
}
