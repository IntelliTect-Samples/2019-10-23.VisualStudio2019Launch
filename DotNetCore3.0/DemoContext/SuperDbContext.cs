using Microsoft.EntityFrameworkCore;
using System;

namespace DemoContext
{
    public class SuperDbContext : DbContext
    {
        public SuperDbContext(DbContextOptions<SuperDbContext> options)
            : base(options)
        { }

        public DbSet<SuperHero> SuperHeroes { get; set; } = null!;
    }
}
