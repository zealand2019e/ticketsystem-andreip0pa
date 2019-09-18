using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketLibrary;
namespace TicketTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PriceTestMethod()
        {
            ///
            Car car = new Car();
            ///
            double price = car.Price();
            ///
            Assert.AreEqual(price, 240);

        }
        [TestMethod]
        public void VehicleTypeTestMethod()
        {
            ///
            Car car = new Car();
            ///
            string type = car.VehicleType();
            ///
            Assert.AreEqual(type, "Car");
        }
    }
}
