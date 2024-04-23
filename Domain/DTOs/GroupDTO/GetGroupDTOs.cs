using Domain.Entities;
using Domain.Enums;

namespace Domain.DTOs.GroupDTO;

public class GetGroupDTOs
{
    
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }
    public int CourseId { get; set; }
    public Course? Course { get; set; }
}
