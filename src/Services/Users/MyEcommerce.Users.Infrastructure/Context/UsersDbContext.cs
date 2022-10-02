using Microsoft.EntityFrameworkCore;
using MyEcommerce.Users.Core.Entities;

namespace MyEcommerce.Users.DAL.Context;

internal sealed class UsersDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; init; } = null!;

    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("authflow");
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}