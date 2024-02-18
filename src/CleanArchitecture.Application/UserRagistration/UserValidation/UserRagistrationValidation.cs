using CleanArchitecture.Application.UserRagistration.Command;
using FluentValidation;


namespace CleanArchitecture.Application.UserRagistration.UserValidation
{
    public class UserRagistrationValidation : AbstractValidator<UserRegistrationCommand>
    {
        public UserRagistrationValidation()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .WithMessage("Email must not be empty");
            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .WithMessage("Password not be empty");
        }

    }
}
