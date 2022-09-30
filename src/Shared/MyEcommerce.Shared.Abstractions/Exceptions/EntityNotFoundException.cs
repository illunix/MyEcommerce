namespace MyEcommerce.Shared.Abstractions.Exceptions;

public sealed class EntityNotFoundException : Exception
{
    public EntityNotFoundException(string entityName) : base($"{entityName} with provided id was not found.") { }
}