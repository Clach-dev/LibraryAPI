using Application.Dtos;
using MediatR;

namespace Application.UseCases.UserCases.Commands.RegisterUserCase
{
    public class RegisterUserCommand : IRequest<UserReadDto>
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Patrynomic { get; set; }

        public DateTime Birthday { get; set; }
    }
}
