using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class PracticeDBContext : DbContext
    {
        public PracticeDBContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<Practice> practices { get; set; }

    }
}
