using corregidorApi.Models;
using Microsoft.EntityFrameworkCore;

namespace corregidorApi.Persistence
{
    public class CorregidorDbContext : DbContext
    {
        public CorregidorDbContext(DbContextOptions<CorregidorDbContext>options)
        :base(options)
        {
        }        
        public DbSet<UserData> UserData { get; set; }
    }
}