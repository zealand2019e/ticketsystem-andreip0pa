using System;
using TicketLibrary;
namespace CarTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            
            Console.WriteLine(c1.Price());

            Console.Read();

            Car c2 = new Car();
            c2.Brobizz = true;
            Console.WriteLine(c2.Price()+"  "+c2.VehicleType());
        }
    }
}
