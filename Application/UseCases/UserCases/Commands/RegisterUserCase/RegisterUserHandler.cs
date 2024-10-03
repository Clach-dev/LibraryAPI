using Application.Dtos;
using Application.IRepositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.UserCases.Commands.RegisterUserCase
{
    public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, UserReadDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public RegisterUserHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper; 
        }

        public async Task<UserReadDto> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var newUser = _mapper.Map<User>(request);

            await _userRepository.AddAsync(newUser, cancellationToken);

            await _userRepository.SaveChangesAsync(cancellationToken);

            return _mapper.Map<UserReadDto>(newUser);
        }
    }
}
