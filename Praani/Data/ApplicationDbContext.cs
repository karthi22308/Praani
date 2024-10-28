using Microsoft.EntityFrameworkCore;
using Praani.Models;

namespace Praani.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<user> user { get; set; }
    }
}
