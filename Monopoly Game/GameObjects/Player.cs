using Monopoly_Game.GameExceptions;
using Monopoly_Game.GameObjects.GameActions;
using Monopoly_Game.GameObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects
{
    public class Player : IPlayer
    {
        private string name;
        private int Balance;
        private int position;
        private IMonopolyGame game; 
            

        public IMonopolyGame GetGame()
        {
            return this.game;
        }

        public Player(string name, int money , MonopolyGame game)
        {
            this.name = name;
            this.Balance = money;
            this.game = game;
            this.position = 0;
            this.Join(game);
        }


        public Player(string name, int money)
        {
            this.name = name;
            this.Balance = money;
           
        }


        public Player()
        {
            this.name = "Player";
            this.Balance = 0;
        }



        public void Buy(ITile tile)
        {
            tile.Buy(this);
            //TODO: Adjust the money
            //Player.PayMoney(Tile.GetPrice())
        }

        public int GetBalance()
        {
            return this.Balance;
        }

        public string GetName()
        {
            return this.name;
        }


        public int GetPosition()
        {
            return this.position;
        }


        /// <summary>
        /// Jump number of steps on the board. If the Player is not linked to a game
        /// then the funciton will have no effect.
        /// current position is updated after the function.
        /// </summary>
        /// <param name="moves">number of steps to jump</param>
        public void Jump(int moves)
        {
            if (game == null)
                return;
            int tileCount = game.CountTiles();
            int location = position + moves;
            position = (location >= tileCount ? location - tileCount : location);

            ITile tile = game.GetTileAt(position);
            tile.Perfom();
        }

        public void Jump(ITile tile)
        {
            throw new NotImplementedException();
        }

        public int Pay(int money)
        {
            throw new NotImplementedException();
        }

        public void Receive(int money)
        {
            if (this.game == null)
                throw new GameException("User can not receive Balance");
            this.Balance = this.Balance + money;
            

        }

        public int Roll()
        {
            return game.Roll();
        }

        public void Sell(ITile tile)
        {
            throw new NotImplementedException();
        }


        /**
         * Join player to a Monopoly Game 
         * it set the link in player to Game and add him to the game
         * 
         */
         
        public void Join(IMonopolyGame game)
        {
            this.game = game;
            game.AddPlayer(this);
        }

        public void Leave()
        {
            if (this.game == null)
                return;
            game.RemovePlayer(this);
            this.game = null;
        }

        public void unlink()
        {
            this.game = null;
        }

        public void PlayTurn()
        {
            int d1 = Roll(); 
            int d2 = Roll();
            Console.WriteLine(name +" is Rolling : " + d1 + " " + d2);
            Jump(d1 + d2);
            foreach (IGameAction action in game.GetBoard().getTileAt(position).GetActions())
            {
                Console.WriteLine("\n<<<" + action.GetActionText() + ">>>");
            }

            Console.WriteLine(game.GetBoard().ToString());
            Console.ReadLine();

            if (d1 == d2)
            {
                int e1 = Roll();
                int e2 = Roll();
                Console.WriteLine(name + " is Rolling Double: " + e1 + " " + e2);
                Console.ReadLine();
                Jump(e1 + e2);
                foreach (IGameAction action in game.GetBoard().getTileAt(position).GetActions())
                {
                    Console.WriteLine("\n[[" + action.GetActionText() + "]]"
                        );
                }
                Console.WriteLine(game.GetBoard().ToString());

           
                Console.ReadLine();

                if (e1 == e2)
                {
                    Console.WriteLine(name + " is Rolling Triple to Jail: ");
                    // GO To Jail
                    GoTo(4);
                    Console.WriteLine(game.GetBoard().ToString());
                    Console.ReadLine();
                }

            }



        }

        public void GoTo(int tileIndex)
        {
            if (game == null || tileIndex > game.CountTiles())
                return;
            this.position = tileIndex;
            ITile tile = game.GetTileAt(position);
            tile.Perfom();

        }

        public void RecieveMoney(int amount)
        {
            Balance += amount;
        }

        public void PayMoney(int amount)
        {
            if (amount > Balance)
                throw new GameException("Player has gone bankrupt");

            Balance -= amount;
        }
    }
}

