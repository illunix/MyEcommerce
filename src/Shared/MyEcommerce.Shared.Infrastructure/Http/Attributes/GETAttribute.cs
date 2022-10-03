namespace MyEcommerce.Shared.Infrastructure.Http.Attributes;

[AttributeUsage(AttributeTargets.Struct)]
public sealed class GETAttribute : Attribute 
{
    public GETAttribute(
        string route = "",
        bool auth = false
    ) { }
}