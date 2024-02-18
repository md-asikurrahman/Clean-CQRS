using MediatR;


namespace CleanArchitecture.Application.UserRagistration.Command
{
    public record UserLogInCommand : IRequest<string>
    {


    }
}
