using Monopoly_Game.GameObjects.GameActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects
{
    public interface ITile
    {
        string GetLable();
        int getPrice();
        void Buy(ITile tile);
        void Sell(ITile tile);
        void Perfom();
        void addAction(IGameAction action); 
        List<IGameAction> GetActions();

    }
}
