using Microsoft.EntityFrameworkCore;
using MyClosetWeb.Models;

namespace MyClosetWeb.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<User> Users { get; set; }

        public DbSet<Clothes> Clothes { get; set; }

        public DbSet<MyClosetWeb.Models.Closet>? Closet { get; set; }

    }
}
