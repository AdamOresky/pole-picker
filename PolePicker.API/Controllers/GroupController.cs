using Microsoft.AspNetCore.Mvc;
using PolePicker.Application.Contracts.Requests.Group;
using PolePicker.Application.Contracts.Responses.Group;
using PolePicker.Application.Services.Interfaces;

namespace pole_picker.Controllers;

[Route("api/v1/[controller]")]
public class GroupController(IGroupService groupService)
{
    [HttpPost]
    public async Task<ActionResult<GroupResponse>> CreateGroupAsync(CreateGroupRequest request)
    {
        return await groupService.CreateGroupAsync(request);
    }
    
    [HttpPost("join")]
    public async Task<ActionResult<GroupResponse>> JoinGroupAsync(JoinGroupRequest request)
    {
        throw new NotImplementedException();
    }
}