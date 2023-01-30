
using System;
using System.Web.Mvc;

namespace MVCUnitTestingDemo.Tests.Controllers
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
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.About() as ViewResult;
            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Contact() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
    }

    internal class Assert
    {
        internal static void AreEqual(string v, dynamic message)
        {
            throw new NotImplementedException();
        }

        internal static void IsNotNull(ViewResult result)
        {
            throw new NotImplementedException();
        }
    }

    internal class HomeController
    {
        internal ViewResult About()
        {
            throw new NotImplementedException();
        }

        internal ViewResult Contact()
        {
            throw new NotImplementedException();
        }

        internal ViewResult Index()
        {
            throw new NotImplementedException();
        }
    }

    internal class TestMethodAttribute : Attribute
    {
    }

    internal class TestClassAttribute : Attribute
    {
    }
}