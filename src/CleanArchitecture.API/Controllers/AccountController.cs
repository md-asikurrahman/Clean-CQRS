using CleanArchitecture.API.Models.AccountModels;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using CleanArchitecture.Application.DTOs;



namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public readonly ISender _sender;
        public AccountController(ISender sender)
        {
                _sender = sender;
        }

        [HttpPost]
        public async Task<ActionResult<UserRegistrationDto>> UserRegistration([FromBody]UserRegistrationModel request)
        {
            try
            {
                return await _sender.Send(request.PrepareCommand());
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
