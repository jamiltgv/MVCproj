using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace MyMVC.Models;

public class ApplicationContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<People> People { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }

    /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"Server=DESKTOP-N7AOKBI\SQLEXPRESS;Database=Market;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=True;");
     */
}
