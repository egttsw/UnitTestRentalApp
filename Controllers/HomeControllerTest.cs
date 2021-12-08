using Microsoft.VisualStudio.TestTools.UnitTesting;
using Equipment_Rental_Application.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Equipment_Rental_Application.Controllers;
using Equipment_Rental_Application.Data;

namespace UnitTestRentalApp
{
    [TestClass]
    public class UnitTestHomeController
    {
        // Testing returned views by the controller
        [TestMethod]
        public void UnitTestIndex()
        {
            // Arrange
            DbContextOptions<ApplicationDbContext> options = new DbContextOptions<ApplicationDbContext>();
            ApplicationDbContext db = new ApplicationDbContext(options);
            HomeController objUnitTestHomeController = new HomeController(db);

            // Act
            ViewResult objViewResult = objUnitTestHomeController.Index() as ViewResult;

            //Assert
            Assert.AreEqual("Index", objViewResult.ViewName, "Index view fault in HomeController");
        }

        [TestMethod]
        public void UnitTestHistory()
        {
            // Arrange
            DbContextOptions<ApplicationDbContext> options = new DbContextOptions<ApplicationDbContext>();
            ApplicationDbContext db = new ApplicationDbContext(options);
            HomeController objUnitTestHomeController = new HomeController(db);

            // Act
            ViewResult objViewResult = objUnitTestHomeController.History() as ViewResult;

            //Assert
            Assert.AreEqual("History", objViewResult.ViewName, "History view fault in HomeController");
        }

    }
}