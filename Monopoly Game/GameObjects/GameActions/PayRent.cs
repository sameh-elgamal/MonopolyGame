using Monopoly_Game.GameObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.GameActions
{
    public class PayRent : SimpleGameAction
    {

        public PayRent(string actionLabel, ITile tile, IMonopolyGame game): base(actionLabel, game)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override void Perform()
        {
            //Check if tile is not owned
            if (!GetTile().IsOwned())
                return;

            //Check if tile is owned by current player
            IPlayer owner = GetTile().GetOwner();
            IPlayer player = GetGame().GetCurrentPlayer();
            if (owner == player)
                return;

            int rent = GetTile().GetRent();

            player.TakeMoney(rent);
            owner.AddMoney(rent);
        }

        public override bool IsAllowed()
        {
            return GetTile().IsOwned();
        }
    }
}
