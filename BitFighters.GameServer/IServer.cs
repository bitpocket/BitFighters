﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    interface IServer
    {
        void LogInPlayer(string name, string password);
        void LogOutPlayer(string name);
        void RegisterPlayer(string name, string password);
        IEnumerable<IGameHeader> GetGameHeaders();
        IGame CreateGame(string gameName);
        IGame JoinGame(string gameId);
        void JoinGame(string playerName, string gameId);
        void WaitForOtherPlayer();
        void StartTheGame(string playerName, string gameId);
        void ValidateMove(string gameId, string playerName, IMoveData moveData);
        void MakeMove(string gameId, string playerName, IMoveData moveData);
    }
}
