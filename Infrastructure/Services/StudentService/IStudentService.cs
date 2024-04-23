using Domain.DTOs.StudentDTO;
using Domain.Response;

namespace Infrastructure.AutoMapper.StudentService;

public interface IStudentService
{
    Task <Response<string>> AddStudent(AddStudentDTO student);
    Task <Response<List<GetStudentDTO>>> GetStudents();
    Task  <Response<string>> UpdateStudent(UpdateStudentDTO update);
    Task <Response<string>> DeleteStudent(int id);
}
