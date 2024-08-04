
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace Data.Contexts;
using System;
using System.Collections.Generic;
using Core.Entities;
using Core.Constants;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AppDbContext : DbContext
{
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Seller> Sellers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-IOO78DD\\SQLEXPRESS;Database=ConsoleCommerce;Trusted_Connection=true;TrustServerCertificate=true;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}