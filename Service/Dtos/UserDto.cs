using Domain.Entities;

namespace Service.Dtos;

public class UserDto : AddUserDto
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }

    public static implicit operator UserDto(User user)
    {
        return new UserDto()
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Password = user.Password,
            Gender = user.Gender,
            CreatedAt = user.CreatedAt
        };
    }
}
