using System;

namespace Storebæltsbroen
{
    public class Car:TicketLibrary.Car
    {
        public override double Price()

        {
            double price = 240;
            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday || DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
               price -= price * 20 / 100;
            }
            if (Brobizz)
            {
                price -= price * 5 / 100;
            }
            return price;
        }
}
}
