using Application.UseCases.UserCases.Commands.RegisterUserCase;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("users")]
    [ApiController]
    public class UserController(IMediator mediator) : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> RegisterUser(RegisterUserCommand registerUserCommand, CancellationToken cancellationToken)
        {
            var user = mediator.Send(registerUserCommand, cancellationToken);

            return Ok(user);
        }
    }
}