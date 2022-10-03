namespace MyEcommerce.Shared.Infrastructure.Http.Attributes;

[AttributeUsage(AttributeTargets.Struct)]
public sealed class DELETEAttribute : Attribute 
{
    public DELETEAttribute(
        string route = "",
        bool auth = false
    ) { }
}