﻿using System;

namespace TicketLibrary
{
    /// <summary>
    /// A simple class representing a Car
    /// </summary>
    public class Car
    {
        private string _licensePlate;

        /// <summary>
        /// Represents the license plate of the car 
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
            double price = 240;
            return price;
        }
        /// <summary>
        /// Shows the vehicle type
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "Car";
        }

    }
}