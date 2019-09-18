using System;

namespace TicketLibrary
{
    /// <summary>
    /// A simple class representing a Car
    /// </summary>
    public class Car:Vehicle
    {
    

        /// <summary>
        /// Represents the license plate of the car 
        /// </summary>
        
        
          

        
            
  

        /// <summary>
        /// Shows the price
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            double price = 240;
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
