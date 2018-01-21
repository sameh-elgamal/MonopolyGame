using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects
{
    public class Properity
    {
        private int price;
        //private int cost;
        private ColorSets color;
        private int HouseCount;
        private int HotelCount;
        private ProperityDeed deed;
        private bool onMortgage;

        public Properity()
        {
            deed = new ProperityDeed(0, 0, 0, 0, 0, 0, 0, 0, 0);
            onMortgage = false;
        }

        public Properity(int price, ProperityDeed deed, ColorSets color)
        {
            this.price = price;
            this.deed = deed;
            this.color = color;
            onMortgage = false;

            HouseCount = 0;
            HotelCount = 0;
        }


        public int GetPrice()
        {
            return this.price;
        }

        public int CalculateRent()
        {
            int cost = 0;

            switch (HouseCount)
            {
                case 1:
                    cost += deed.Rent1House;
                    break;
                case 2:
                    cost += deed.Rent2Houses;
                    break;
                case 3:
                    cost += deed.Rent3Houses;
                    break;
                case 4:
                    cost += deed.Rent4Houses;
                    break;
            }

            cost += HotelCount * deed.RentWithHotel;

            //TODO: Check if player owns a color set. If so double base rent
            return cost;
        }
    }
}
