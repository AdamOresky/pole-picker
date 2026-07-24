namespace PolePicker.Domain.Entities.Base;

public class BaseEntity
{
    public long Id { get; set; }
    
    public Guid Uuid { get; set; } = Guid.NewGuid();
}