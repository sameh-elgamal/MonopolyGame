using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects
{
    public class ProperityDeed : Deed
    {

        public int Rent1House { get; }
        public int Rent2Houses { get; }
        public int Rent3Houses { get; }
        public int Rent4Houses { get; }
        public int RentWithHotel { get; }

        public int HouseCost { get; }
        public int HotelCost { get; }

        public ProperityDeed(int rent, int rent1House, int rent2Houses, int rent3Houses, int rent4Houses,
            int rentWithHotel, int houseCost, int hotelCost, int mortgageValue) : base(rent, mortgageValue)
        {
            this.Rent1House = rent1House;
            this.Rent2Houses = rent2Houses;
            this.Rent3Houses = rent3Houses;
            this.Rent4Houses = rent4Houses;
            this.RentWithHotel = rentWithHotel;
            this.HouseCost = houseCost;
            this.HouseCost = hotelCost;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

            // s.AppendFormat("Rent {0}  ", base.rent);
            s.AppendFormat("\nRent one House {0} ", this.Rent1House);
            s.AppendFormat("\nRent two Houses {0} ", this.Rent2Houses);
            s.AppendFormat("\nRent three Houses {0} ", this.Rent3Houses);
            s.AppendFormat("\nRent four Houses {0} ", this.Rent4Houses);
            s.AppendFormat("\nRent Hotel {0} ", this.RentWithHotel);

            return s.ToString();
        }

        //public new int GetRent()
        //{
        //    return base.GetRent();
        //}

    }
}
