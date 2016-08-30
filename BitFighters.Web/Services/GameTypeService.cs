using Game;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BitFighters.Web.Services
{
    public class GameTypeService : IGameTypeService
    {
        public IEnumerable<string> GetGameTypes()
        {
            var type = typeof(IGame);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p))
                .Select(c => c.Name)
                .ToList();

            return types;
        }
    }
}
