using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.Interfaces
{
    public interface IBoard
    {
        /// <summary>
        /// Adds tiles to board
        /// </summary>
        void CreateBoard();
        //ITile getTiles();
        /// <summary>
        /// Gets the amount of tiles linked with board
        /// </summary>
        /// <returns>Amount of tiles</returns>
        int getTileCount();
        /// <summary>
        /// Gets a tile from specified index
        /// </summary>
        /// <param name="index">Index of tile</param>
        /// <returns>Requested tile</returns>
        ITile getTileAt(int index);
    }
}
