using AutoMapper;
using Domain.DTOs.GroupDTO;
using Domain.Entities;
using Domain.Response;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services.GroupService;

public class GroupService : IGroupService
{
     private readonly DataContext _context;
    private readonly IMapper _mapper;
    public GroupService(DataContext context,IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task<Response<string>> AddGroup(AddGroupDTOs groupDTOs)
    {
        
        var mapped = _mapper.Map<Group>(groupDTOs);
        await _context.Groups.AddAsync(mapped);
        
        await _context.SaveChangesAsync();
        if (mapped != null)  return new Response<string>("Success");

        return new Response<string>(System.Net.HttpStatusCode.BadRequest,"Faild to add");
    }

    public async Task<Response<string>> DeleteGroup(int id)
    {
       
        var result = await _context.Groups.FirstOrDefaultAsync(e => e.Id == id);
        if (result == null)
        {
            return new Response<string>("Not Found");
        }
         _context.Groups.Remove(result);
         await _context.SaveChangesAsync();
         return new Response<string>("Success");
    }

    public async Task<Response<List<GetGroupDTOs>>> GetGroups()
    {
        
        var result = await _context.Groups.ToListAsync();
        return new Response<List<GetGroupDTOs>>(_mapper.Map<List<GetGroupDTOs>>(result));
    }

    public async Task<Response<string>> UpdateGroup(UpdateGroupDTOs update)
    {
        
        var mapped=_mapper.Map<Group>(update.Id);
        _context.Groups.Update(mapped);
       var result =  await _context.SaveChangesAsync();
       if (result > 0)
       {
        return new Response<string>("Success");
       }
       return new Response<string>("Not Success");
    }

}
