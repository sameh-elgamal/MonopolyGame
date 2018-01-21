using Monopoly_Game.GameObjects.GameActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects
{
    public class UKBoard : Board
    {
       

        public UKBoard(IMonopolyGame game) : base(game)
        {
            CreateBoard();
        }


        public override void CreateBoard()
        {
            ITile tile = new ActionTile("GO Collect £200", this);
            IGameAction action = new ReceiveMoneyAction("Collect £200", 200, GetGame());
            tile.AddAction(action);
            base.GetTiles().Add(tile);

            tile = new ProperityTile("Old Kent", this);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);

            tile = new SimpleTile("Community Chest", this);
            action = new CommunityChestPickCard("Pick Community Chest Card", GetGame());
            tile.AddAction(action);
            base.GetTiles().Add(tile);

            tile = new ActionTile("Income Tax (Pay 10% or $200)", this);
            action = new ReceiveMoneyAction("Income Tax (Pay 10% or $200)", -200, GetGame());
            tile.AddAction(action);
            base.GetTiles().Add(tile);

            tile = new SimpleTile("Chance", this);
            action = new ChancePickACard("Pick Chance Card", GetGame());
            tile.AddAction(action);
            base.GetTiles().Add(tile);

            tile = new SimpleTile("Jail/Just Visiting", this);
            base.GetTiles().Add(tile);

            tile = new SimpleTile("Free Parking", this);
            base.GetTiles().Add(tile);


            tile = new SimpleTile("Chance", this);
            action = new ChancePickACard("Pick Chance Card", GetGame());
            tile.AddAction(action);
            base.GetTiles().Add(tile);

            tile = new SimpleTile("Community Chest", this);
            action = new CommunityChestPickCard("Pick Community Chest Card", GetGame());
            tile.AddAction(action);
            base.GetTiles().Add(tile);

            tile = new SimpleTile("Chance", this);
            action = new ChancePickACard("Pick Chance Card", GetGame());
            tile.AddAction(action);
            base.GetTiles().Add(tile);

            tile = new ActionTile("Super Tax (Pay £100)", this);
            action = new ReceiveMoneyAction("Super Tax(Pay £100)", -100, GetGame());
            tile.AddAction(action);
            base.GetTiles().Add(tile);


        }


    }
}
