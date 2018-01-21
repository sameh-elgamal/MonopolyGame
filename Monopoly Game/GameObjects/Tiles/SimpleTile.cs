using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly_Game.GameObjects.GameActions;
using Monopoly_Game.GameObjects.Interfaces;

namespace Monopoly_Game.GameObjects.Tiles
{
    public class SimpleTile : Tile
    {
        public SimpleTile(string label, IBoard board) : base(label, board)
        {
        }

        public override void Perfom()
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GetLabel());
            return sb.ToString();
        }
    }
}
