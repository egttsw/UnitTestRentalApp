using Microsoft.VisualStudio.TestTools.UnitTesting;
using Equipment_Rental_Application.Helpers;

namespace UnitTestRentalApp
{
    [TestClass]
    public class PriceCalculationTest
    {
        // Testing price calculations for three given types: heavy, regular and specialized
        [TestMethod]
        public void TestPriceForHeavy()
        {
            // Arrange
            Calculations calculate = new Calculations();
            string type = "Heavy";
            int duration = 6;

            // Act
            int price = calculate.RentalPrice(type, duration);

            //Assert
            Assert.AreEqual(price, 460, "Price calculation incorrect for heavy equipment");
        }

        [TestMethod]
        public void TestPriceForRegular()
        {
            // Arrange
            Calculations calculate = new Calculations();
            string type = "Regular";
            int duration = 5;

            // Act
            int price = calculate.RentalPrice(type, duration);

            //Assert
            Assert.AreEqual(price, 340, "Price calculation incorrect for regular equipment");
        }

        [TestMethod]
        public void TestPriceForSpecialized()
        {
            // Arrange
            Calculations calculate = new Calculations();
            string type = "Specialized";
            int duration = 7;

            // Act
            int price = calculate.RentalPrice(type, duration);

            //Assert
            Assert.AreEqual(price, 440, "Price calculation incorrect for specialized equipment");
        }
    }
}