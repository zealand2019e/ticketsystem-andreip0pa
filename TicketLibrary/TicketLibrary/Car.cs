using System;

namespace TicketLibrary
{
    /// <summary>
    /// A simple class representing a Car
    /// </summary>
    public class Car:Vehicle
    {
    
        public override double Price()
        {
            double price = 240;
            if (DateTime.Today.DayOfWeek==DayOfWeek.Saturday || DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                price -= price * 20 / 100;
            }
            if (Brobizz)
            {
                price -= price * 5 / 100;
            }
            return price;
        }
        /// <summary>
        /// Shows the vehicle type
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
           
            return "Car";
        }

    }
}
