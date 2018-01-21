using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly_Game.GameObjects.GameActions;

namespace Monopoly_Game.GameObjects
{
    public class SimpleTile : Tile
    {
        public SimpleTile(string label, IBoard board) : base(label, board)
        {
        }

        public override void Perfom()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GetLabel());
            return sb.ToString();
        }
    }
}
