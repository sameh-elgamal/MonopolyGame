using Monopoly_Game.GameExceptions;
using Monopoly_Game.GameObjects;
using Monopoly_Game.GameObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game
{
    public class Bank : IBank
    {
        private int Balance;

        public Bank()
        {
            this.Balance = 15140;
        }


        public void Deposit(int money)
        {
            if(money > 0)
            this.Balance = this.Balance + money;
        }

        public int GetBalance()
        {
            return Balance;
        }

        public int Withdraw(int money)
        {
            if (money > this.Balance)
                throw new GameException("Bank has insufficent funds [" + Balance +"] to pay " + money);

            Balance = Balance - money;
            return money;
        }
    }
}
