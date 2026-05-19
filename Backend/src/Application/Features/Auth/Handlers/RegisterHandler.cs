using Application.Features.Auth.Commands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Features.Auth.Handlers;

public class RegisterHandler : IRequestHandler<RegisterCommand, string>
{
    private readonly IUserRepository _userRepository;

    public RegisterHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<string> Handle(
        RegisterCommand request,
        CancellationToken cancellationToken)
    {
        var passwordHasher = new PasswordHasher<User>();

        var user = new User
        {
            Id = Guid.NewGuid(),
            Name = request.RegisterDto.Name,
            Email = request.RegisterDto.Email,
            Role = request.RegisterDto.Role
        };

        user.PasswordHash =
            passwordHasher.HashPassword(user, request.RegisterDto.Password);

        await _userRepository.AddUserAsync(user);

        return "User Registered Successfully";
    }
}