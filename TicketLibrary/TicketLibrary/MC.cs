using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class MC
    {
        private string _licensePlate;

        /// <summary>
        /// Represents the license plate
        /// </summary>
        public string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }

        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        /// Shows the price
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            double price = 125;
            return price;
        }
        /// <summary>
        /// Shows the vehicle type
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "MC";
        }


    }
}
