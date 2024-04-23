using Domain.Enums;

namespace Domain.DTOs.GroupDTO;

public class UpdateGroupDTOs
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public Status Status { get; set; }
    public int CourseId { get; set; }
}
