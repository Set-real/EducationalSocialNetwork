using Microsoft.EntityFrameworkCore;
using SocialNetwork.Data.Models;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace SocialNetwork.Data.Contecst
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().ToTable("Users");
        }
    }
}
