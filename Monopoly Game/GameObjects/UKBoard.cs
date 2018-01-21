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

            deed = new ProperityDeed(18, 90, 250, 700, 875, 1050, 150, 150, 110);
            properity = new Properity(220, deed, ColorSets.red);
            tile = new ProperityTile("Strand", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);


            tile = new SimpleTile("Chance", this);
            action = new ChancePickACard("Pick Chance Card", GetGame());
            tile.AddAction(action);
            base.GetTiles().Add(tile);



            deed = new ProperityDeed(18, 90, 250, 700, 875, 1050, 150, 150, 110);
            properity = new Properity(220, deed, ColorSets.red);
            tile = new ProperityTile("Fleet Street", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);

            deed = new ProperityDeed(20, 100, 300, 750, 925, 1100, 150, 150, 120);
            properity = new Properity(240, deed, ColorSets.red);
            tile = new ProperityTile("Trafalgar Square", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);


            //TODO: change tile to utility 
            tile = new SimpleTile("Fenchurch St. Station", this);
            base.GetTiles().Add(tile);

            deed = new ProperityDeed(22, 110, 330, 800, 975, 1150, 150, 150, 150);
            properity = new Properity(260, deed, ColorSets.yellow);
            tile = new ProperityTile("Leicester Square", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);

            deed = new ProperityDeed(22, 110, 330, 800, 975, 1150, 150, 150, 150);
            properity = new Properity(260, deed, ColorSets.yellow);
            tile = new ProperityTile("Coventry Street", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);


            //TODO: change tile to utility 
            tile = new SimpleTile("Water Works", this);
            base.GetTiles().Add(tile);


            deed = new ProperityDeed(22, 120, 360, 850, 1025, 1200, 140, 140, 150);
            properity = new Properity(280, deed, ColorSets.yellow);
            tile = new ProperityTile("Piccadilly", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);

            //TODO: change tile to utility 
            tile = new SimpleTile("Go to Jail", this);
            GetTiles().Add(tile);


            deed = new ProperityDeed(26, 130, 390, 900, 1100, 1275, 150, 150, 200);
            properity = new Properity(300, deed, ColorSets.green);
            tile = new ProperityTile("Regent Street", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);


            deed = new ProperityDeed(26, 130, 390, 900, 1100, 1275, 150, 150, 200);
            properity = new Properity(300, deed, ColorSets.green);
            tile = new ProperityTile("Oxford Street", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);


            tile = new SimpleTile("Community Chest", this);
            action = new CommunityChestPickCard("Pick Community Chest Card", GetGame());
            tile.AddAction(action);
            base.GetTiles().Add(tile);


            deed = new ProperityDeed(28, 150, 450, 1000, 1200, 1400, 160, 160, 200);
            properity = new Properity(320, deed, ColorSets.green);
            tile = new ProperityTile("Bond Street", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);

            //TODO: change tile to utility 
            tile = new SimpleTile("Liverpool Street Station", this);
            base.GetTiles().Add(tile);

            tile = new SimpleTile("Chance", this);
            action = new ChancePickACard("Pick Chance Card", GetGame());
            tile.AddAction(action);
            base.GetTiles().Add(tile);


            deed = new ProperityDeed(35, 175, 500, 1100, 1300, 1500, 200, 200, 175);
            properity = new Properity(350, deed, ColorSets.blue);
            tile = new ProperityTile("Park Lane", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);



            tile = new ActionTile("Super Tax (Pay £100)", this);
            action = new ReceiveMoneyAction("Super Tax(Pay £100)", -100, GetGame());
            tile.AddAction(action);
            base.GetTiles().Add(tile);

            deed = new ProperityDeed(50, 200, 600, 1400, 1700, 2000, 200, 200, 200);
            properity = new Properity(400, deed, ColorSets.blue);
            tile = new ProperityTile("Mayfair", this, properity);
            action = new PayRent("Pay Rent", tile, GetGame());
            tile.AddAction(action);
            GetTiles().Add(tile);

        }


    }
}
