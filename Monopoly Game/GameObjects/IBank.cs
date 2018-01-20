using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects
{
    public interface IBank
    {
        void Deposit(int money);
        int Withdraw(int money);
        int GetBalance();

    }
}
