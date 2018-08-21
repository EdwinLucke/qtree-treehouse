using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using qtree.Asp.Net.WebApp;
using qtree.Asp.Net.WebApp.Controllers;

namespace qtree.Asp.Net.WebApp.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();
            
            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual($"Home Page - Net", result.ViewBag.Title);
        }
    }
}
