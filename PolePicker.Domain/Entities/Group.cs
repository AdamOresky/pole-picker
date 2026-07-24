using PolePicker.Domain.Entities.Base;

namespace PolePicker.Domain.Entities;

public class Group : BaseEntity
{
    public required string Name { get; set; }
    
    public required string InviteCode { get; set; }
    
    public DateTime CreatedAt { get; set; }
}