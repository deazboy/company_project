using Microsoft.EntityFrameworkCore;

namespace WebAppl1.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<InfoNumber> InfoNumber { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}

