namespace Domain.DTOs.CourseDTOs;

public class UpdateCourseDTO
{
    
     public int Id { get; set; }
    public string? Name { get; set; } = null!;
    public string?  Description { get; set; }
}
