using FluentValidation;
using MyEcommerce.Users.Application.Commands;

namespace MyEcommerce.Users.API.Validators;

public sealed class SignInCommandValidator : AbstractValidator<SignInCommand>
{
    public SignInCommandValidator()
    {
        RuleFor(q => q.Email)
            .NotEmpty()
            .EmailAddress();

        RuleFor(q => q.Password)
            .NotEmpty();
    }
}