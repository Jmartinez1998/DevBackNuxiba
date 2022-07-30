using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Prueba_2.WebAPInuxiba;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }
}