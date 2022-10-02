namespace MyEcommerce.Users.Core.Entities.Abstract;

public record EntityBase
{
    public Guid Id { get; } = Guid.NewGuid();
}