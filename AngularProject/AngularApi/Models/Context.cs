using Microsoft.EntityFrameworkCore;

namespace AngularApi.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-D3O3ANC\\SQLSERVER;database=ArgusWebApi; integrated security= true;");
        }
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<PersonInfo> PersonInfos { get; set; }

    }
}
