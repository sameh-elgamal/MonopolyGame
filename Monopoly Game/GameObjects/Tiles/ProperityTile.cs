using Monopoly_Game.GameObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.Tiles
{
    public class ProperityTile : Tile
    {
        private Properity properity;

        public ProperityTile(string label, IBoard board, Properity properity) : base(label, board)
        {
            this.properity = properity;
        }

        public override int GetRent()
        {
            return properity.CalculateRent();
        }

        public override void Perfom()
        {
            GetActions()[0].Perform();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GetLabel());
            sb.Append(" \t"+this.properity.GetPrice());
            return sb.ToString();
        }

    }
}
