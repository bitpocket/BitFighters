using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitFighters.Web.Services
{
    public interface IGameTypeService
    {
        IEnumerable<IGameHeader> GetGameTypes();
    }
}
