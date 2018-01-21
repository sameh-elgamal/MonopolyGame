using Monopoly_Game.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.Interfaces
{
    public interface IMonopolyGame
    {
        /// <summary>
        /// Adds a player to game
        /// </summary>
        /// <param name="player">Player to add</param>
        void AddPlayer(IPlayer player);
        /// <summary>
        /// Removes a player from game
        /// </summary>
        /// <param name="player">Player to remove</param>
        void RemovePlayer(IPlayer player);
        /// <summary>
        /// Gets the amount of players linked
        /// </summary>
        /// <returns>Number of players</returns>
        int CountPlayer();
        /// <summary>
        /// Gets the amount of tiles linked
        /// </summary>
        /// <returns>Number of tiles</returns>
        int CountTiles();
        /// <summary>
        /// Gets the current player
        /// </summary>
        /// <returns>Current player</returns>
        IPlayer GetCurrentPlayer();
        IBank GetBank();
        /// <summary>
        /// Gets a tile at specified index
        /// </summary>
        /// <param name="index">Index of tile</param>
        /// <returns>Tile requested</returns>
        ITile GetTileAt(int index);
        /// <summary>
        /// Gets all linked players
        /// </summary>
        /// <returns>List of players</returns>
        List<IPlayer> GetPlayers();
        /// <summary>
        /// Rolls 2 dice
        /// </summary>
        /// <returns>Number Rolled</returns>
        int Roll();
        /// <summary>
        /// Gets board in use
        /// </summary>
        /// <returns>Linked Board</returns>
        IBoard GetBoard();



    }

}
