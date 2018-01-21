using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects
{
    public class ProperityTile : Tile
    {

        public ProperityTile(string label, IBoard board) : base(label, board)
        {
        }

        public override int GetRent()
        {
            return 10;
        }

        public override void Perfom()
        {
            GetActions()[0].Perform();
        }
    }
}
