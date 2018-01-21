using Monopoly_Game.GameExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects
{
    public abstract class Board : IBoard
    {
        private List<ITile> tiles;
        private IMonopolyGame game;

 
        public Board(IMonopolyGame game)
        {
            tiles = new List<ITile>();
            this.game = game;
        }

        /// <summary>
        /// return the Game linked to the board.
        /// </summary>
        /// <returns> referece to the Monopoly Game</returns>
        public IMonopolyGame GetGame()
        {
            return this.game;
        }

        /// <summary>
        /// GetTiles return the list of tiles as object. it can be used to reference 
        /// list of tiles of the Board Class
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ITile> GetTiles()
        {
            return this.tiles;
        }

        public abstract void CreateBoard();




        public ITile getTileAt(int index)
        {
            if (index > tiles.Count)
                throw new GameException("Tile "+ index +" is not on the Board");
            return this.tiles.ElementAt(index);
        }

        public int getTileCount()
        {
            return tiles.Count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach (ITile tile in tiles )
            {
                
                sb.Append("["+ i+"] "+tile.ToString());
                foreach (IPlayer player in this.game.GetPlayers())
                {
                    if(player.GetPosition() == i)
                    {
                        sb.Append("\t["+player.GetName());
                        sb.Append("\t" + player.GetBalance()+"] ");
                    }
                }
                i++;
                sb.AppendLine("");

            }

            return sb.ToString();
        }

    }
}
