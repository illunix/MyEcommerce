using MyEcommerce.Users.Core.Entities.Abstract;

namespace MyEcommerce.Users.Core.Entities;

public sealed record UserEntity(
    string Email,
    string Password,
    string Salt
) : EntityBase
{
    public DateTime CreatedAt { get; } = DateTime.Now;
}