using Domain.DTOs.CourseDTOs;
using Domain.Response;

namespace Infrastructure.Services.CourseService;

public interface ICourseService
{
    
    Task <Response<string>> AddCourse(AddCourseDTO course);
    Task <Response<List<GetCoursesDTO>>> GetCourses();
    Task  <Response<string>> UpdateCourse(UpdateCourseDTO update);
    Task <Response<string>> DeleteCourse(int id);
}
