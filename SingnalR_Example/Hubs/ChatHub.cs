
using Microsoft.AspNetCore.SignalR;
using SingnalR_Example.Datas;
using SingnalR_Example.Models.Entities.Concretes;

namespace SingnalR_Example.Hubs;


public class ChatHub : Hub
{
    private readonly AppDbContext _dbContext;

    public ChatHub(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddUserToHub(string? userName, string? name, string? surname)
    {
        var newUser = new User()
        {
            UserName = userName,
            Name = name,
            Surname = surname
        };

        _dbContext.Users.Add(newUser);
        await _dbContext.SaveChangesAsync();
    }
}
