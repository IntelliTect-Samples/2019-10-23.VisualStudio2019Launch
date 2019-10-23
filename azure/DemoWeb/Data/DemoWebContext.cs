using Microsoft.EntityFrameworkCore;

namespace DemoWeb.Data
{
    public class DemoWebContext : DbContext
    {
        public DemoWebContext (DbContextOptions<DemoWebContext> options)
            : base(options)
        {
        }

        public DbSet<DemoWeb.Models.Messages> Messages { get; set; }
    }
}
