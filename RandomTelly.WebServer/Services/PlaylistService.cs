using Microsoft.EntityFrameworkCore;
using RandomTelly.RCL.Core.Models;
using RandomTelly.RCL.Core.Services;
using RandomTelly.WebServer.Data;

namespace RandomTelly.WebServer.Services;

internal class PlaylistService : IPlaylistService
{
    private readonly AppDbContext _dbContext;

    public PlaylistService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Playlist>> GetAll()
    {
        return await _dbContext.Playlists.ToListAsync();
    }

    public async Task<Playlist> Save(Playlist playlist)
    {
        var existingPlaylist = await _dbContext.Playlists.FindAsync(playlist.Id);
        
        if (existingPlaylist == null)
        {
            _dbContext.Playlists.Add(playlist);
        }
        else
        {
            _dbContext.Entry(existingPlaylist).CurrentValues.SetValues(playlist);
        }
        
        await _dbContext.SaveChangesAsync();
        return playlist;
    }
}
