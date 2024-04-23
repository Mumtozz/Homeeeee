using Domain.DTOs.StudentDTO;
using Domain.Response;
using Infrastructure.AutoMapper.StudentService;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller;


[Route("/api/Student")]
[ApiController]
public class StudentController(IStudentService service) : ControllerBase
{
    [HttpGet("Get-Students")]
    public async Task <Response<List<GetStudentDTO>>> GetStudents()
    {
        return await service.GetStudents();
    }
    [HttpPost("Add-Student")]
        public async Task <Response<string>> AddStudent(AddStudentDTO student)
        {
            return await service.AddStudent(student);
        }
        
    [HttpPut("Update-Student")]
     public async Task <Response<string>> UpdateStudent(UpdateStudentDTO update)
    {
        return await service.UpdateStudent(update);
    }
       [HttpDelete("Delete-Student")]
    public async Task <Response<string>> DeleteStudent(int id)
    {
        return await service.DeleteStudent(id);
    }



}
