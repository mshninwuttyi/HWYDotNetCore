using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HWYDotNetCore.BlazorServerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HWYDotNetCore.BlazorServerApp;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { 
    
    }

    public DbSet<BlogModel> Blogs { get; set; }
}
