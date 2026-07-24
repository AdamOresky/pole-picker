using Microsoft.EntityFrameworkCore;
using PolePicker.Application.Contracts.Requests.Group;
using PolePicker.Application.Contracts.Responses.Group;
using PolePicker.Application.Mappings;
using PolePicker.Application.Services.Interfaces;
using PolePicker.Infrastructure.Persistence;

namespace PolePicker.Application.Services;

public class GroupService(AppDbContext dbContext) : IGroupService
{
    public async Task<GroupResponse> CreateGroupAsync(CreateGroupRequest request)
    {
        var group = request.ToGroup();
        
        dbContext.Add(group);
        await dbContext.SaveChangesAsync();
        
        var created = await dbContext.Groups.FirstAsync(x => x.Id == group.Id);
        return created.ToGroupResponse();
    }
    
    public async Task JoinGroupAsync(JoinGroupRequest request)
    {
        throw new NotImplementedException();
    }
}