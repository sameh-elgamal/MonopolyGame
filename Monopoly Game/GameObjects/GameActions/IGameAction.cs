using Monopoly_Game.GameObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.GameActions
{
    public interface IGameAction
    {
        void Perform();
        string GetActionText();
        ITile GetTile();
        void LinkTile(ITile tile);
        IMonopolyGame GetGame();
        bool IsAllowed();
    }
}
