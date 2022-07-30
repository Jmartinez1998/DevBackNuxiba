using Microsoft.EntityFrameworkCore;
using Prueba_2.WebAPInuxiba.Models;
using System.Configuration;

namespace Prueba_2.WebAPInuxiba;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<User> usuarios {get; set;}
    public DbSet<Employee> empleados {get; set;}
}