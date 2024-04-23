using AutoMapper;
using Domain.DTOs.CourseDTOs;
using Domain.Entities;
using Domain.Response;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services.CourseService;

public class CourseService : ICourseService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public CourseService(DataContext context,IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task <Response<string>> AddCourse(AddCourseDTO course)
    {
        var mapped = _mapper.Map<Course>(course);
        await _context.Courses.AddAsync(mapped);
        await _context.SaveChangesAsync();
        return new Response<string>("Success");
    }

    public async Task <Response<string>> DeleteCourse(int id)
    {
        var result = await _context.Courses.FirstOrDefaultAsync(e => e.Id == id);
        if (result == null)
        {
            return new Response<string>("Not Found");
        }
         _context.Courses.Remove(result);
         await _context.SaveChangesAsync();
         return new Response<string>("Success");
    }


    public async Task <Response<List<GetCoursesDTO>>> GetCourses()
    {
        var result = await _context.Courses.ToListAsync();
        return new Response<List<GetCoursesDTO>>(_mapper.Map<List<GetCoursesDTO>>(result));
    }

    public async Task<Response<string>> UpdateCourse(UpdateCourseDTO update)
    {
        var mapped=_mapper.Map<Course>(update);
        _context.Courses.Update(mapped);
       var result=  await _context.SaveChangesAsync();
       if (result > 0)
       {
        return new Response<string>("Success");
       }
       return new Response<string>("Not Success");

    }

}
