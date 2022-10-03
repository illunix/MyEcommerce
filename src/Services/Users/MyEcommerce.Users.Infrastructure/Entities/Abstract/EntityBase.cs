namespace MyEcommerce.Users.DAL.Entities.Abstract;

public record EntityBase
{
    public Guid Id { get; } = Guid.NewGuid();
}