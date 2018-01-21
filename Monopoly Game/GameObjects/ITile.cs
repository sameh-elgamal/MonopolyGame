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
        string GetLabel();
        int GetPrice();
        void Buy(IPlayer owner);
        void Sell(ITile tile);
        void Perfom();
        void AddAction(IGameAction action); 
        List<IGameAction> GetActions();
        IPlayer GetOwner();
        bool IsOwned();
        int GetRent();
    }
}
