using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.Interfaces
{
    public interface IPlayer
    {
        int GetPosition();
        /// <summary>
        /// Linkes player to a monopoly game
        /// </summary>
        /// <param name="game">Game to link to</param>
        void Join(IMonopolyGame game);
        /// <summary>
        /// Removes player from game
        /// </summary>
        void Leave();
        /// <summary>
        /// Moves player forward
        /// </summary>
        /// <param name="moves">Positions to move</param>
        void Jump(int moves);
        /// <summary>
        /// Moves player to tile
        /// </summary>
        /// <param name="tile">Tile to move to</param>
        void Jump(ITile tile);
        /// <summary>
        /// Moves player to tile at index
        /// </summary>
        /// <param name="tileIndex">Index of tile</param>
        void GoTo(int tileIndex);
        /// <summary>
        /// Rolls 2 dice
        /// </summary>
        /// <returns>Number rolled</returns>
        int Roll();
        /// <summary>
        /// Gets the player name
        /// </summary>
        /// <returns>Player's name</returns>
        string GetName();
        /// <summary>
        /// Gets balance
        /// </summary>
        /// <returns>The amount of money the player has</returns>
        int GetBalance();
        /// <summary>
        /// Buys a tile
        /// </summary>
        /// <param name="tile">Tile to buy</param>
        void Buy(ITile tile);
        /// <summary>
        /// Sells a tile
        /// </summary>
        /// <param name="tile">Tile to sell</param>
        void Sell(ITile tile);
        //TODO: Change function to target specific player
        int Pay(int money);
        void Receive(int money);
        /// <summary>
        /// Unlinks player from game
        /// </summary>
        void Unlink();
        /// <summary>
        /// Plays turn and handles game actions
        /// </summary>
        void PlayTurn();
        /// <summary>
        /// Adds money to player's balance
        /// </summary>
        /// <param name="amount">Amount to recieve</param>
        void AddMoney(int amount);
        /// <summary>
        /// Takes away money from player's balance
        /// </summary>
        /// <param name="amount">Amount to take</param>
        void TakeMoney(int amount);

    }
}
