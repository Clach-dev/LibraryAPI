using Application.Dtos.Tokens;
using MediatR;

namespace Application.UseCases.UserCases.Commands.LoginUserCase
{
    public class LoginUserCommand : IRequest<TokensReadDto>
    {
        public string Login { get; set; }

        public string Password { get; set; }
    }
}
