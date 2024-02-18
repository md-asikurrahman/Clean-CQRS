using CleanArchitecture.Application.UserRagistration.Command;

namespace CleanArchitecture.API.Models.AccountModels
{
    public class UserRegistrationModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UserRegistrationCommand PrepareCommand()
        {
            return new UserRegistrationCommand()
            {
                FullName = FullName,
                Email = Email,
                Password = Password
            };
        }

    }
}
