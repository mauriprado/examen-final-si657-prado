using Microsoft.EntityFrameworkCore;
using Recommendations.API.Shopping.Domain.Models;

namespace Recommendations.API.Shared.Persistence.Context;

public class AppDbContext: DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Product>().ToTable("productos");
        builder.Entity<Product>().HasKey(p => p.Id);
        builder.Entity<Product>().Property(p => p.Id).IsRequired();
        builder.Entity<Product>().Property(p => p.Nombre).IsRequired();
        builder.Entity<Product>().Property(p => p.Descripcion).IsRequired();
        builder.Entity<Product>().Property(p => p.Caracteristicas).IsRequired();
        builder.Entity<Product>().Property(p => p.Precio).IsRequired();
        builder.Entity<Product>().Property(p => p.Url).IsRequired();
        builder.Entity<Product>().Property(p => p.Categoria).IsRequired();
        builder.Entity<Product>().Property(p => p.Subcategoria).IsRequired();

        builder.Entity<User>().ToTable("usuarios");
        builder.Entity<User>().HasKey(p => p.Id);
        builder.Entity<User>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<User>().Property(p => p.Nombre).IsRequired();
    }
}