﻿using Monopoly_Game.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game
{
    public interface IMonopolyGame
    {
        void AddPlayer(IPlayer player);
        void RemovePlayer(IPlayer player);
        int CountPlayer();
        int CountTiles();
        IPlayer GetCurrentPlayer();
        IBank GetBank();
        ITile getTileAt(int index);
        List<IPlayer> getPlayers();
        int Roll();
        IBoard GetBoard();



    }

}