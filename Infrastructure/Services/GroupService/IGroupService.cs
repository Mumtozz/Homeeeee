using Domain.DTOs.GroupDTO;
using Domain.Response;

namespace Infrastructure.Services.GroupService;

public interface IGroupService
{
    
   public Task <Response<string>> AddGroup(AddGroupDTOs groupDTOs);
   public  Task <Response<List<GetGroupDTOs>>> GetGroups();
   public Task  <Response<string>> UpdateGroup(UpdateGroupDTOs update);
   public Task <Response<string>> DeleteGroup(int id);
}
