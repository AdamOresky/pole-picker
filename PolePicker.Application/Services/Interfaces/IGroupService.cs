using PolePicker.Application.Contracts.Requests.Group;
using PolePicker.Application.Contracts.Responses.Group;

namespace PolePicker.Application.Services.Interfaces;

public interface IGroupService
{
    Task<GroupResponse> CreateGroupAsync(CreateGroupRequest request);
    
    Task JoinGroupAsync(JoinGroupRequest request);
}