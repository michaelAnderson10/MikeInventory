using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikeInventory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Security.RightsManagement;
using System.Diagnostics.Metrics;
using System.Windows.Media;

namespace MikeInventory.Data;

public class MikeInventoryContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Tool> Tools { get; set; } = null!;
    public DbSet<Part> Parts { get; set; } = null!;
    public DbSet<Supplier> Suppliers { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");      
    }

}

