using System;

namespace TicketLibrary
{
    public class Car
    {
        private string _licensePlate;

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

        public double Price()
        {
            double price = 240;
            return price;
        }
        public string VehicleType()
        {
            return "Car";
        }

    }
}
