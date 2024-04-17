using Service.Dtos;

namespace Service.Interfaces;

public interface IAccountService
{
    Task RegisterAsync(AddUserDto dto);
    Task<string> LoginAsync(LoginDto dto);
    Task SendCodeAsync(string email);
    Task<bool> VerifyEmailAsync(string email,string code);
    Task UpdatePasswordAsync(string email, string password);
    Task ForgotPasswordAsync();
}
