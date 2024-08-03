using HWYDotNetCore.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HWYDotNetCore.WebApi.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<BlogModel> Blogs { get; set; }
    }
}
