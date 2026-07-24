using PolePicker.Application.Contracts.Requests.Group;
using PolePicker.Application.Contracts.Responses.Group;
using PolePicker.Domain.Entities;

namespace PolePicker.Application.Mappings;

public static class GroupMappings
{
    public static Group ToGroup(this CreateGroupRequest request)
    {
        return new Group {
            Name = request.Name,
            InviteCode = request.Name,
            CreatedAt = DateTime.UtcNow
        };
    }
    
    public static GroupResponse ToGroupResponse(this Group group)
    {
        return new GroupResponse
        {
            Name = group.Name,
            InviteCode = group.InviteCode
        };
    }
}