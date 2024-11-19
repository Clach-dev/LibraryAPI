using Application.Dtos;
using Application.Interfaces.IAlgorithm;
using Application.Interfaces.IRepositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.UserCases.Commands.RegisterUserCase
{
    public class RegisterUserHandler(IUserRepository userRepository, IPasswordHasher passwordHasher, IMapper mapper) : IRequestHandler<RegisterUserCommand, UserReadDto>
    {
        public async Task<UserReadDto> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var newUser = mapper.Map<User>(request);
            newUser.Password = passwordHasher.HashPassword(request.Password);

            await userRepository.AddAsync(newUser, cancellationToken);

            await userRepository.SaveChangesAsync(cancellationToken);

            return mapper.Map<UserReadDto>(newUser);
        }
    }
}
