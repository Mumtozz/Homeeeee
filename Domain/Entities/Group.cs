using Domain.Enums;

namespace Domain.Entities;

public class Group : BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public Status Status { get; set; }
    public int CourseId { get; set; }
    public Course? Course { get; set; }
    public List<StudentGroup>? StudentGroups { get; set; }
    public List<MentorGroup>? MentorGroups { get; set; }
}
