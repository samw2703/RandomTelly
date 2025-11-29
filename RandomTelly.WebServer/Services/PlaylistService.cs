using RandomTelly.RCL.Core.Models;
using RandomTelly.RCL.Core.Services;

namespace RandomTelly.WebServer.Services;

internal class PlaylistService : IPlaylistService
{
    /*
     COPILOT TODO:
        Implement the methods to manage playlists using entity framework core with a sqlite database.
     */

    public Task<IEnumerable<Playlist>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Playlist> Save(Playlist playlist)
    {
        throw new NotImplementedException();
    }
}
