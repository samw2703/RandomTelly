using Microsoft.EntityFrameworkCore;
using RandomTelly.RCL.Core.Models;

namespace RandomTelly.WebServer.Data;

internal class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Playlist> Playlists { get; set; } = null!;
}
