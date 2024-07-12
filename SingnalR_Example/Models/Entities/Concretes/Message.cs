using SingnalR_Example.Models.Entities.Abstracts;

namespace SingnalR_Example.Models.Entities.Concretes;

public class Message : Entity
{
    public string? Text { get; set; }
    public bool IsRead { get; set; } = false;

    // foregin key
    public int UserId { get; set; }
    public int GroupId { get; set; }

    // NavigationProperty
    public User? User { get; set; }
    public Group? Group { get; set; }
}
