
using Microsoft.EntityFrameworkCore;
using MVC_TemplateApp.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }
    public DbSet<ProductPhoto> ProductPhotos { get; set; }
}
