using System;
using Game;

namespace KnotsAndCrosses
{
    public class KnotsAndCrosses : IGame
    {
        public int Id { get; set; }

        public int MaxPlayer { get; } = 2;

        public bool CalculateEndCondition()
        {
            throw new NotImplementedException();
        }

        public IGameState GetGameState()
        {
            throw new NotImplementedException();
        }

        public IPlayer GetWinner()
        {
            throw new NotImplementedException();
        }

        public void MakeMove(params object[] moveData)
        {
            throw new NotImplementedException();
        }

        public void ValidateMove(params object[] moveData)
        {
            throw new NotImplementedException();
        }
    }
}
