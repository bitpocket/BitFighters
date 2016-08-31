using System;

namespace Game
{
    public class GameHeader: IGameHeader
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinPlayer { get; set; }
        public int MaxPlayer { get; set; }
    }
}