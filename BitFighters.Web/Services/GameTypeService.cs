using Game;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BitFighters.Web.Services
{
    public class GameTypeService : IGameTypeService
    {
        public IEnumerable<IGameHeader> GetGameTypes()
        {
            return new List<IGameHeader>()
            {
                new GameHeader() {Name="Knots and cresses", Description = "Sipmly game", MinPlayer =2, MaxPlayer=2 },
                new GameHeader() {Name="Go", Description = "No such sipmly game", MinPlayer =2, MaxPlayer=2 }
            };
        }
    }
}
