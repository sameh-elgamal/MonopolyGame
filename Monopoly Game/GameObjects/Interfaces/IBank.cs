using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.Interfaces
{
    public interface IBank
    {
        /// <summary>
        /// Adds money to bank balance
        /// </summary>
        /// <param name="money">Amount to deposit</param>
        void Deposit(int money);
        /// <summary>
        /// Takes money from bank
        /// </summary>
        /// <param name="money">Amount to withdraw</param>
        /// <returns>Withdrawn amount</returns>
        int Withdraw(int money);
        int GetBalance();

    }
}
