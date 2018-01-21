using Monopoly_Game.GameObjects.GameActions;
using Monopoly_Game.GameObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.Tiles
{
    public class ActionTile : Tile
    {
        
        public ActionTile(string label, IBoard board): base(label,board)
        {
            
        }

        public override void Perfom()
        {
            base.GetActions()[0].Perform();
        }


        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(base.GetLabel());
            return sb.ToString();
          

        }

    }
}
