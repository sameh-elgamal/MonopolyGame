﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.GameActions
{
    public class PayRent : SimpleGameAction
    {

        public PayRent(string actionLabel, ITile tile, IMonopolyGame game): base(actionLabel, game)
        {

        }

    
        public override void Perform()
        {
            throw new NotImplementedException();
        }
    }
}