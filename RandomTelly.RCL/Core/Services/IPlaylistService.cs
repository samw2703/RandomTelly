using RandomTelly.RCL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTelly.RCL.Core.Services;

public interface IPlaylistService
{
    Task<IEnumerable<Playlist>> GetAll();
    Task<Playlist> Save(Playlist playlist);
}
