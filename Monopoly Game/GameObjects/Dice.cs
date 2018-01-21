using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects
{
    class Dice
    {
        Random random = new Random();
        private int maxValue;

        public Dice()
        {
            maxValue = 6;
        }


        public Dice(int maxValue)
        {
            this.maxValue = maxValue;
        }


        public int Roll()
        {
            return random.Next(1, maxValue + 1);
        }
    }
}
