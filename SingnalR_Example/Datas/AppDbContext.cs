using Microsoft.EntityFrameworkCore;
using SingnalR_Example.Models.Entities.Concretes;

namespace SingnalR_Example.Datas;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    // Tables
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Message> Messages { get; set; }
    public virtual DbSet<Group> Groups { get; set; }
}
