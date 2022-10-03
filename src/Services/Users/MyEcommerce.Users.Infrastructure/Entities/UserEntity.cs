using MyEcommerce.Users.DAL.Entities.Abstract;

namespace MyEcommerce.Users.DAL.Entities;

public sealed record UserEntity(
    string Email,
    string Password,
    string Salt
) : EntityBase
{
    public DateTime CreatedAt { get; } = DateTime.Now;
}