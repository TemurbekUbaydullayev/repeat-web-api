using Domain.Enums;

namespace Domain.Entities;

public class User :BaseEntitiy
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
    public bool IsEmailConfirmed { get; set; }
    public UserRole UserRole { get; set; } = UserRole.User;
    public Gender Gender { get; set; } 

}
