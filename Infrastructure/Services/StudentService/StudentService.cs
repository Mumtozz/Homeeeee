using AutoMapper;
using Domain.DTOs.StudentDTO;
using Domain.Entities;
using Domain.Response;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.AutoMapper.StudentService;

public class StudentService : IStudentService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public StudentService(DataContext context,IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task <Response<string>> AddStudent(AddStudentDTO student)
    {
        var mapped = _mapper.Map<Student>(student);
        await _context.Students.AddAsync(mapped);
        await _context.SaveChangesAsync();
        return new Response<string>("Success");
    }

    public async Task <Response<string>> DeleteStudent(int id)
    {
        var result = await _context.Students.FirstOrDefaultAsync(e => e.Id == id);
        if (result == null)
        {
            return new Response<string>("Not Found");
        }
         _context.Students.Remove(result);
         await _context.SaveChangesAsync();
         return new Response<string>("Success");
    }


    public async Task <Response<List<GetStudentDTO>>> GetStudents()
    {
        var result = await _context.Students.ToListAsync();
        return new Response<List<GetStudentDTO>>(_mapper.Map<List<GetStudentDTO>>(result));
    }

    public async Task<Response<string>> UpdateStudent(UpdateStudentDTO update)
    {
        var mapped=_mapper.Map<Student>(update);
        _context.Students.Update(mapped);
       var result=  await _context.SaveChangesAsync();
       if (result > 0)
       {
        return new Response<string>("Success");
       }
       return new Response<string>("Not Success");

    }

    

}
