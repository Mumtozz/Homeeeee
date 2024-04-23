namespace Domain.Entities;

public class Course : BaseEntity
{
    public string? Name { get; set; } = null!;
    public string?  Description { get; set; }
    public List<Group>? Groups { get; set; }
}
