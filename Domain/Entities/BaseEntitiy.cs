using System.Data;

namespace Domain.Entities;

public class BaseEntitiy
{
    public Guid Id { get; set; }
    public DateTime CreatedAt {  get; set; } 
}
