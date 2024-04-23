using Domain.DTOs.CourseDTOs;
using Domain.Response;
using Infrastructure.Services.CourseService;
using Infrastructure.Services.GroupService;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller;

public class CourseController(ICourseService service) : ControllerBase
{
    [HttpGet("Get-Courses")]
    public async Task<Response<List<GetCoursesDTO>>> GetCourses()
    {
        return await service.GetCourses();
    }
    [HttpPost("Add-Course")]
    public async Task<Response<string>> AddCourse(AddCourseDTO course)
    {
        return await service.AddCourse(course);
    }

    [HttpPut("Update-Course")]
    public async Task<Response<string>> UpdateCourse(UpdateCourseDTO update)
    {
        return await service.UpdateCourse(update);
    }
    [HttpDelete("Delete-Course")]
    public async Task<Response<string>> DeleteCourse(int id)
    {
        return await service.DeleteCourse(id);
    }



}
