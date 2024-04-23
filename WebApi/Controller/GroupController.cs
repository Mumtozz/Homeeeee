using Domain.DTOs.GroupDTO;
using Domain.Response;
using Infrastructure.Services.GroupService;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller;


[Route("/api/Group")]
[ApiController]
public class GroupController(IGroupService service) : ControllerBase
{
    [HttpGet("Get-Groups")]
    public async Task<Response<List<GetGroupDTOs>>> GetGroups()
    {
        return await service.GetGroups();
    }
    [HttpPost("Add-Group")]
    public async Task<Response<string>> AddGroupDTOs(AddGroupDTOs groupDTOs)
    {
        return await service.AddGroup(groupDTOs);
    }

    [HttpPut("Update-Group")]
    public async Task<Response<string>> UpdateGroup(UpdateGroupDTOs update)
    {
        return await service.UpdateGroup(update);
    }
    [HttpDelete("Delete-Group")]
    public async Task<Response<string>> DeleteGroup(int id)
    {
        return await service.DeleteGroup(id);
    }
}
