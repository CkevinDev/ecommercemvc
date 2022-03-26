using Microsoft.EntityFrameworkCore;

namespace ecommercemvc.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
    }
}
