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
        void Jump(int moves);
        void Jump(ITile tile);
        void GoTo(int tileIndex);
        int Roll();
        string GetName();
        int GetBalance();
        void Buy(ITile tile);
        void Sell(ITile tile);
        int Pay(int money);
        void Receive(int money);
        void unlink();
        void PlayTurn();
        void RecieveMoney(int amount);
        void PayMoney(int amount);

    }
}
