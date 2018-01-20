using System.Collections.Generic;

namespace Monopoly_Game.GameObjects
{
    
    public class MonopolyGame : IMonopolyGame
    {
        private List<IPlayer> players;
        private IBoard board;
        private int currentPlayer;
        private IBank Bank;
        private Dice dice;


        

        public MonopolyGame()
        {
            players = new List<IPlayer>();
            Bank = new Bank();
            dice = new Dice();

            // change this to create a board by factory
            board = new UKBoard(this);

        }


     
        /// <summary>
        /// Add Player to the game if player already assigned the function return without
        /// any action
        /// </summary>
        /// <param name="player">Player to Add</param>
        public void AddPlayer(IPlayer player)
        {
            if (players.Contains(player))
                return;
            players.Add(player);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public ITile getTileAt(int index)
        {
            return board.getTileAt(index);
        }


        /**
         *  Return the number of players in the Game 
         *  0 when there is no player.
         * 
         */ 

        public int CountPlayer()
        {
            return players.Count;
        }

        public int CountTiles()
        {
            if (board == null)
                return 0;
            return board.getTileCount();
        }

        /**
         * Remove player from Monopoly Game 
         * it set the link in player to null and remove the player from the game
         * 
         * 
         */

        public void RemovePlayer(IPlayer player)
        {
            if (players.Contains(player))
            {
               players.Remove(player);
               player.unlink();
            }
        }


        public List<IPlayer> getPlayers()
        {
            return players;
        }


        public IBoard GetBoard()
        {
            return this.board;
        }

        public IPlayer GetCurrentPlayer()
        {
                return players[currentPlayer];
        }

        public IBank GetBank()
        {
            return Bank;
        }


        public int Roll()
        {
            return dice.roll();
        }
    }
}