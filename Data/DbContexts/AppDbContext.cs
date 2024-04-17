using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Data.DbContexts;

public class AppDbContext(DbContextOptions<AppDbContext> dbContext) : DbContext(dbContext)
{
    public DbSet <User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>()
            .HasIndex(x => x.Email)
            .IsUnique();
        modelBuilder.Entity<User>()
            .HasData(new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Admin",
                LastName = "Adminov",
                Email = "ubaydullayev117@gmail.com",
                Gender = Gender.Male,
                UserRole = UserRole.Admin,
                Password = "f79d83aa040a27d599b9a1066ef6d968",
                IsEmailConfirmed = true
            });
    }

}
