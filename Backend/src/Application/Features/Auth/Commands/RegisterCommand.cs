using Application.Features.Auth.DTOs;
using MediatR;

namespace Application.Features.Auth.Commands;

public class RegisterCommand : IRequest<string>
{
    public RegisterDto RegisterDto { get; set; }

    public RegisterCommand(RegisterDto registerDto)
    {
        RegisterDto = registerDto;
    }
}