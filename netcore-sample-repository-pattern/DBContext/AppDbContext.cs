using Microsoft.EntityFrameworkCore;
using netcore_sample_repository_pattern.Model;
using System.Collections.Generic;

namespace netcore_sample_repository_pattern.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
