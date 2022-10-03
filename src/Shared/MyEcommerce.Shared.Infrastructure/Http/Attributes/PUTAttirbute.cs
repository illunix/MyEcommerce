namespace MyEcommerce.Shared.Infrastructure.Http.Attributes;

[AttributeUsage(AttributeTargets.Struct)]
public sealed class PUTAttribute : Attribute
{
    public PUTAttribute(
        string route = "",
        bool auth = false
    ) { }
}
