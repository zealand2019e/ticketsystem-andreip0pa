using System;

namespace Oresund
{
    public class Car:TicketLibrary.Car
    {
        bool brobizz = false;

        public override double Price()
        {
            double price = 410;
            if (brobizz)
            {
                price = 161;
            }
            return price;
        }
        public override string VehicleType()
        {
            return "Oresund Car";
        }
    }
}
