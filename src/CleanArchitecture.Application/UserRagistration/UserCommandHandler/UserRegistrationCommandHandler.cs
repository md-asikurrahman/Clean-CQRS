using CleanArchitecture.Application.UserRagistration.Command;
using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.UserRagistration.UserCommandHandler
{
    public class UserRegistrationCommandHandler : IRequestHandler<UserRegistrationCommand, string>
    {
        //private readonly IRepository<AppUser, int> _repository;
        //public UserRegistrationCommandHandler(IRepository repository)
        //{
        //    _repository = repository;
        //}
        public Task<string> Handle(UserRegistrationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
