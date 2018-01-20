using Monopoly_Game.GameExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.GameActions
{
    class ReceiveMoneyAction : SimpleGameAction
    {
      
        private int money;      // about of money transfer from/to the bank.

        public ReceiveMoneyAction(string ActionLable, int money, IMonopolyGame game): base(ActionLable, game)
        {
            this.money = money;
        }


        /// <summary>
        /// 
        /// Transfer money from the bank to the current player if the bank does not have
        /// enough funds, function throw GameException.
        /// 
        /// </summary>
        public override void Perform()
        {
            IPlayer player = base.GetGame().GetCurrentPlayer();
            IBank bank = base.GetGame().GetBank();

            try
            {
                int cash = bank.Withdraw(money);
                player.Receive(cash);

            }
            catch (GameException e)
            {
                throw new GameException("Can not receive Balance " + e.Message );
            }
        }
    }
}
