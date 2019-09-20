using System;
using System.Collections.Generic;
using System.Text;

namespace Oresund
{
   public class MC:TicketLibrary.MC
    {
        bool brobizz = false;

        public override double Price()
        {
            double price = 210;
            if (brobizz)
            {
                price = 73;
            }
            return price;
        }
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
