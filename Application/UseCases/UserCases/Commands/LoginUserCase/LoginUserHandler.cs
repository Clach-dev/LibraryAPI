using Application.Dtos.Tokens;
using Application.Exceptions;
using Application.Interfaces.IAlgorithm;
using Application.Interfaces.IRepositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.UserCases.Commands.LoginUserCase
{
    public class LoginUserHandler(IUserRepository userRepository, IPasswordHasher passwordHasher, IMapper mapper) : IRequestHandler<LoginUserCommand, TokensReadDto>
    {
        public async Task<TokensReadDto> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var user = (await userRepository.GetByPredicateAsync(user => user.Login == request.Login, cancellationToken)).FirstOrDefault();

            if (user is null)
            {
                throw new NotFoundException(typeof(User).ToString(), request.Login);
            }

            if (!passwordHasher.VerifyHashedPassword(user.Password, request.Password))
            {
                throw new UnauthorizedException("Wrong password");
            }


        }
    }
}