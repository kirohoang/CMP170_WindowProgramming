using Book_Management.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Book_Management.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> users { get; set; }
    }
}
