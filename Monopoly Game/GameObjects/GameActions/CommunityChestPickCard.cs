using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.GameActions
{
    public class CommunityChestPickCard : SimpleGameAction
    {

        public CommunityChestPickCard(string ActionLable, IMonopolyGame game): base(ActionLable, game)
        {

        }


        public override void Perform()
        {
            Console.WriteLine("Pick a Card from community chest");
        }
    }
}
