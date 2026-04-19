using C_AutomationFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace C_AutomationFramework
{
    public class LoginTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void ValidLoginTest()
        {
            var page = new LoginPage(driver);

            page.Navigate();
            page.Login("tomsmith", "SuperSecretPassword!");

            Assert.That(page.GetFlashMessage(), Does.Contain("You logged into a secure area!"));
        }

        [Test]
        public void InvalidLoginTest()
        {
            var page = new LoginPage(driver);

            page.Navigate();
            page.Login("wrongUser", "wrongPass");

            Assert.That(page.GetFlashMessage(), Does.Contain("Your username is invalid!"));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}