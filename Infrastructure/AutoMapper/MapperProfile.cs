using AutoMapper;
using Domain.DTOs.StudentDTO;
using Domain.Entities;

namespace Infrastructure.AutoMapper;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Student,AddStudentDTO>().ReverseMap();
        CreateMap<Student,GetStudentDTO>().ReverseMap();
        CreateMap<Student,UpdateStudentDTO>().ReverseMap();
         // //ForMembers
        // CreateMap< Student,GetStudentDto>()
        //     .ForMember(sDto => sDto.FulName, opt => opt.MapFrom(s => $"{s.FirstName} {s.LastName}"))
        //     .ForMember(sDto => sDto.EmailAddress, opt => opt.MapFrom(s =>s.Email));
        //
        // //Reverse map
        // CreateMap<BaseStudentDto,Student>().ReverseMap();
        //
        // // ignore
        // CreateMap<Student, AddStudentDto>()
        //     .ForMember(dest => dest.FirstName, opt => opt.Ignore());
    }
}
