using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.GameActions
{
    public class ChancePickACard : SimpleGameAction
    {


        public ChancePickACard(string actionKey, string ActionLabel, IMonopolyGame game) : base(actionKey, ActionLabel, game)
        {

        }


        public override void Perform()
        {
            Console.WriteLine("Pick a Card form Chance Chest");
            throw new NotImplementedException();
        }
    }
}
