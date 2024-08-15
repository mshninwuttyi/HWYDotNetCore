using HWYDotNetCore.MinimalApi2.Models;
using Microsoft.EntityFrameworkCore;

namespace HWYDotNetCore.MinimalApi2
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<BlogModel> Blogs { get; set; }
    }
}
