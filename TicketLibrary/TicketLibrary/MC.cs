using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class MC:Vehicle
    {
        private string _licensePlate;

        /// <summary>
        /// return the price for crossing teh bridge for an MC 
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            double price = 125;
            return price;
        }
        /// <summary>
        /// Shows the vehicle type
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "MC";
        }


    }
}
