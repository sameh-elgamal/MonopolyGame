using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.GameActions
{
    public interface IGameAction
    {
        string GetActionKey();
        void Perform();
        string GetActionText();
        ITile GetTile();
        void linkTile(ITile tile);
        IMonopolyGame GetGame();

    }
}
