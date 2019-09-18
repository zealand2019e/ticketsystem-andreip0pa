using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
     public abstract class Vehicle
    {
        private string licensePlate;
        public string LicensePlate
        {


            get {

                return licensePlate;

                }



            set {
                if (value.Length > 7)
                {
                    throw new Exception("License plate too long!");
                }
                else
                {
                    licensePlate = value;
                }

                }

        }
        public DateTime Date { get; set; }
        public abstract string VehicleType();
        public abstract double Price();
        
    }
}
