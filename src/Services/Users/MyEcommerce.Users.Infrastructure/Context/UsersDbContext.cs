using Microsoft.EntityFrameworkCore;
using MyEcommerce.Users.DAL.Entities;

namespace MyEcommerce.Users.DAL.Context;

public sealed class UsersDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; init; } = null!;

    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("users");
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}