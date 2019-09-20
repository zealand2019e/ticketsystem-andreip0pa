using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicketLibrary;
namespace TicketTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CarPriceTestMethod()
        {
            ///
            Car car = new Car();
            ///
            double price = car.Price();
            ///
            Assert.AreEqual(price, 240);

        }
        [TestMethod]
        public void CarVehicleTypeTestMethod()
        {
            ///
            Car car = new Car();
            ///
            string type = car.VehicleType();
            ///
            Assert.AreEqual(type, "Car");
        }
        [TestMethod]
        public void MCPriceTestMethod()
        {
            ///
           MC car = new MC();
            ///
            double price = car.Price();
            ///
            Assert.AreEqual(price, 125);

        }
        [TestMethod]
        public void MCVehicleTypeTestMethod()
        {
            ///
            MC car = new MC();
            ///
            string type = car.VehicleType();
            ///
            Assert.AreEqual(type, "MC");
        }
        [TestMethod]
        public void VehicleExceptionTest()
        {
            ///
            Car c = new Car();
           
         
            ///
            Assert.ThrowsException<Exception>(()=> { c.LicensePlate = "aaaaaaaaaa"; }, "License plate too long!");
        }

        [TestMethod]
        public void CarDiscoutnTest()
        {
            ///
            Car car = new Car();
            ///
           
            car.Brobizz = true;
            

            double price = car.Price();
            ///
            Assert.AreEqual(price, 228);
        }
    }
}
