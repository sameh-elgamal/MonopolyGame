using Monopoly_Game.GameObjects.GameActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.Interfaces
{
    public interface ITile
    {
        /// <summary>
        /// Gets the Label of the tile
        /// </summary>
        /// <returns>Tile label</returns>
        string GetLabel();
        /// <summary>
        /// Gets the price of tile
        /// </summary>
        /// <returns>Returns price if available</returns>
        int GetPrice();
        /// <summary>
        /// Links tile to owner
        /// </summary>
        /// <param name="owner">Player who bought the tile</param>
        void Buy(IPlayer owner);
        /// <summary>
        /// Unlinks tile from owner
        /// </summary>
        /// <param name="tile">Tile to unlink</param>
        void Sell(ITile tile);
        /// <summary>
        /// Preforms allowed game action
        /// </summary>
        void Perfom();
        /// <summary>
        /// Adds an action to the actions list
        /// </summary>
        /// <param name="action">Action to add</param>
        void AddAction(IGameAction action);
        /// <summary>
        /// Gets all allowed actions
        /// </summary>
        /// <returns></returns>
        List<IGameAction> GetActions();
        /// <summary>
        /// Gets tile owner if tile is owned
        /// </summary>
        /// <returns>Onwer of tile</returns>
        IPlayer GetOwner();
        /// <summary>
        /// Checks if tile is owned
        /// </summary>
        /// <returns>Is Owned</returns>
        bool IsOwned();
        /// <summary>
        /// Gets rent of tile
        /// </summary>
        /// <returns>Rent if set</returns>
        int GetRent();
    }
}
