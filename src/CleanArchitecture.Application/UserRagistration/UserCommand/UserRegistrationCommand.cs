using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.UserRagistration.Command
{
    public record UserRegistrationCommand : IRequest<string>
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public new AppUser CreateUser()
        {
            return new AppUser() { Email = Email, Password = Password, UserName = FullName };
        }
    }
}
