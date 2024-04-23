using Domain.Entities;
using Domain.Enums;

namespace Domain.DTOs.GroupDTO;

public class AddGroupDTOs
{
    
    public string? Name { get; set; }
    public string? Description { get; set; }
    public Status Status { get; set; }
    public int CourseId { get; set; }
}  
