using Monopoly_Game.GameObjects.GameActions;
using Monopoly_Game.GameObjects.Interfaces;
using Monopoly_Game.GameObjects.Tiles;
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

            ProperityDeed deed = new ProperityDeed(2,10,30,90,160,250,30,30,50);
            Properity properity = new Properity(200, deed, ColorSets.brown);
            tile = new ProperityTile("Old Kent", this,properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);


            deed = new ProperityDeed(4, 20, 60, 180, 360, 450, 30, 30, 50);
            properity = new Properity(200, deed, ColorSets.brown);
            tile = new ProperityTile("Whitechapel Road", this, properity);
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

            //TODO: change tile to utility 
            tile = new SimpleTile("King's Cross Station", this);
            base.GetTiles().Add(tile);


            deed = new ProperityDeed(6, 30, 90, 270, 400, 550, 50, 50, 50);
            properity = new Properity(100, deed, ColorSets.lightblue);
            tile = new ProperityTile("The Angel Islington", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);



            tile = new SimpleTile("Chance", this);
            action = new ChancePickACard("Pick Chance Card", GetGame());
            tile.AddAction(action);
            base.GetTiles().Add(tile);


            deed = new ProperityDeed(6, 30, 90, 270, 400, 550, 50, 50, 50);
            properity = new Properity(100, deed, ColorSets.lightblue);
            tile = new ProperityTile("Euston Road", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);


            deed = new ProperityDeed(8, 40, 100, 300, 450, 600, 50, 50, 60);
            properity = new Properity(120, deed, ColorSets.lightblue);
            tile = new ProperityTile("Pentonville Road", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);

            //TODO: change tile to utility 
            tile = new SimpleTile("Jail/Just Visiting", this);
            base.GetTiles().Add(tile);

            deed = new ProperityDeed(10, 50, 150, 450, 625, 750, 100, 100, 70);
            properity = new Properity(140, deed, ColorSets.pink);
            tile = new ProperityTile("Pall Mall", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);

            //TODO: change tile to utility 
            tile = new SimpleTile("Electric Company", this);
            base.GetTiles().Add(tile);

            deed = new ProperityDeed(10, 50, 150, 450, 625, 750, 100, 100, 70);
            properity = new Properity(140, deed, ColorSets.pink);
            tile = new ProperityTile("Whitehall", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);

            deed = new ProperityDeed(12, 60, 180, 500, 700, 900, 100, 100, 80);
            properity = new Properity(160, deed, ColorSets.pink);
            tile = new ProperityTile("Northumberland Avenue", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);

            //TODO: change tile to utility 
            tile = new SimpleTile("Marylebone Station", this);
            base.GetTiles().Add(tile);


            deed = new ProperityDeed(14, 70, 200, 550, 750, 950, 100, 100, 90);
            properity = new Properity(180, deed, ColorSets.orange);
            tile = new ProperityTile("Bow Street", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);


            tile = new SimpleTile("Community Chest", this);
            action = new CommunityChestPickCard("Pick Community Chest Card", GetGame());
            tile.AddAction(action);
            base.GetTiles().Add(tile);




            deed = new ProperityDeed(14, 70, 200, 550, 750, 950, 100, 100, 90);
            properity = new Properity(180, deed, ColorSets.orange);
            tile = new ProperityTile("Marlborough Street", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);


            deed = new ProperityDeed(16, 80, 220, 600, 800, 1000, 100, 100, 100);
            properity = new Properity(200, deed, ColorSets.orange);
            tile = new ProperityTile("Vine Street", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);

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
