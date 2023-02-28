using Microsoft.EntityFrameworkCore;
using TestWeb.Domain.Models;

namespace TestWeb.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Pizza> Pizza { get; set; }
    }
}
