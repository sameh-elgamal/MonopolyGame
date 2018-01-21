using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects
{
    public class Deed
    {
        private int rent;
        private int mortgageValue;

        public Deed(int rent, int mortgageValue)
        {
            this.rent = rent;
            this.mortgageValue = mortgageValue;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine($"Rent = {rent}");
            s.AppendLine($"Mortgage = {mortgageValue}");
            return s.ToString();
        }

        public int GetRent()
        {
            return rent;
        }

        public int GetMortgage()
        {
            return mortgageValue;
        }


    }
}
