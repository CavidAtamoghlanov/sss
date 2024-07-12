using SingnalR_Example.Models.Entities.Abstracts;

namespace SingnalR_Example.Models.Entities.Concretes;

public class User : Entity
{
    public string? UserName { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }


    // NaviogationProperties
    public ICollection<Message>? Messages { get; set; }
    public ICollection<Group>? Groups { get; set; }
}
