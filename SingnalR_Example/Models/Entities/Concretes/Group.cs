using SingnalR_Example.Models.Entities.Abstracts;

namespace SingnalR_Example.Models.Entities.Concretes;

public class Group : Entity
{
    public string? Name { get; set; }

    // Navigation Properties
    public ICollection<User>? Users { get; set; }
    public ICollection<Message>? Messages { get; set; }
}
