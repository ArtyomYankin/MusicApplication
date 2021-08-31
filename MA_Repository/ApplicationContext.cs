using MA_Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace MA_Repository
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}
