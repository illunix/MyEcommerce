namespace MyEcommerce.Shared.Infrastructure.Http.Attributes;

[AttributeUsage(AttributeTargets.Struct)]
public sealed class POSTAttribute : Attribute 
{
    public POSTAttribute(
        string route = "",
        bool auth = false
    ) { }
}