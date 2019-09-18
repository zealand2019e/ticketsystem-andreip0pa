using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class MC:Vehicle
    {
        private string _licensePlate;

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
