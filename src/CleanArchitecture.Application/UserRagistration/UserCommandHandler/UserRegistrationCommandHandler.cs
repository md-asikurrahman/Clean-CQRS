using CleanArchitecture.Application.UserRagistration.Command;
using MediatR;

namespace CleanArchitecture.Application.UserRagistration.UserCommandHandler
{
    public class UserRegistrationCommandHandler : IRequestHandler<UserRegistrationCommand, string>
    {
        public  Task<string> Handle(UserRegistrationCommand request, CancellationToken cancellationToken)
        {

            var result = "Succecfull";
            return Ok(result);
        }

        private Task<string> Ok(string result)
        {
            throw new NotImplementedException();
        }
    }
}
