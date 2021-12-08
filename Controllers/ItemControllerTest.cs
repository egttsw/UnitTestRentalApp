using Microsoft.VisualStudio.TestTools.UnitTesting;
using Equipment_Rental_Application.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Equipment_Rental_Application.Controllers;
using Equipment_Rental_Application.Data;
using Equipment_Rental_Application.Models;

namespace UnitTestRentalApp
{
    [TestClass]
    public class UnitTestItemController
    {
        // Testing returned views by the controller
        [TestMethod]
        public void UnitTestIndex()
        {
            // Arrange
            DbContextOptions<ApplicationDbContext> options = new DbContextOptions<ApplicationDbContext>();
            ApplicationDbContext db = new ApplicationDbContext(options);
            ItemController objUnitTestItemController = new ItemController(db);

            // Act
            ViewResult objViewResult = objUnitTestItemController.Index() as ViewResult;

            //Assert
            Assert.AreEqual("Index", objViewResult.ViewName, "Index view fault in HomeController");
        }

    }
}