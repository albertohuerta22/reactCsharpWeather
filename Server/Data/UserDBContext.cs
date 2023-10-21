// UserDbContext.cs

using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity relationships and constraints here

            // Seed data
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "user1", Password = "password1", FirstName = "Jan", LastName = "Doe", Email = "janndoe@email.com" },
                new User { Id = 2, Username = "user2", Password = "password2", FirstName = "John", LastName = "Doe", Email = "johndoe@email.com"}
                // Add more seed data as needed
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
