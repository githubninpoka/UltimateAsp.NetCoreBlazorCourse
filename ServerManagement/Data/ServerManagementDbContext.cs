using Microsoft.EntityFrameworkCore;
using ServerManagement.Models;

namespace ServerManagement.Data;

public class ServerManagementDbContext : DbContext
{
    public required DbSet<Server> Servers { get; set; }

    public ServerManagementDbContext(DbContextOptions<ServerManagementDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    
        modelBuilder.Entity<Server>().HasData(
            new Server { ServerId = 1, Name = "Server1", City = "Toronto" },
            new Server { ServerId = 2, Name = "Server2", City = "Toronto" },
            new Server { ServerId = 3, Name = "Server3", City = "Toronto" },
            new Server { ServerId = 4, Name = "Server4", City = "Toronto" },
            new Server { ServerId = 5, Name = "Server5", City = "Montreal" },
            new Server { ServerId = 6, Name = "Server6", City = "Montreal" },
            new Server { ServerId = 7, Name = "Server7", City = "Montreal" },
            new Server { ServerId = 8, Name = "Server8", City = "Ottawa" },
            new Server { ServerId = 9, Name = "Server9", City = "Ottawa" },
            new Server { ServerId = 10, Name = "Server10", City = "Calgary" },
            new Server { ServerId = 11, Name = "Server11", City = "Calgary" },
            new Server { ServerId = 12, Name = "Server12", City = "Halifax" },
            new Server { ServerId = 13, Name = "Server13", City = "Halifax" }
        );
    }
}
