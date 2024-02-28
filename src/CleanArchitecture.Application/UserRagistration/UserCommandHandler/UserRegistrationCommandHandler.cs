using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Application.UserRagistration.Command;
using CleanArchitecture.Application.ViewModel;
using MediatR;
using CleanArchitecture.DataTransfer.UnitOfWorks;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.UserRagistration.UserCommandHandler
{
    public class UserRegistrationCommandHandler : IRequestHandler<UserRegistrationCommand, UserRegistrationDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IRepository<AppUser, int> _repository;
        //public UserRegistrationCommandHandler(IRepository repository)
        //{
        //    _repository = repository;
        //}
        public UserRegistrationCommandHandler(IUnitOfWork unitOfWork)
        {
          _unitOfWork = unitOfWork;
        }
        
        async Task<UserRegistrationDto> IRequestHandler<UserRegistrationCommand, UserRegistrationDto>.Handle(UserRegistrationCommand request, CancellationToken cancellationToken)
        {
            var userEntity = request.CreateUser();
            await _unitOfWork.GetGenericRepository<AppUser>().AddAsync(userEntity,cancellationToken);
            
            UserRegistrationDto user = new UserRegistrationDto();

            user.FullName = request.FullName;
            user.Email = request.Email;
            
            return user;
        }
    }
}
