using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
