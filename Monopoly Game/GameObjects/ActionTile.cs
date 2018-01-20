using Monopoly_Game.GameObjects.GameActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects
{
    public class ActionTile : Tile
    {
        
        public ActionTile(string lable, IBoard board): base(lable,board)
        {
            
        }





        public override void Perfom()
        {
            base.GetActions()[0].Perform();
        }


        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(base.GetLable());
            return sb.ToString();
          

        }

    }
}
