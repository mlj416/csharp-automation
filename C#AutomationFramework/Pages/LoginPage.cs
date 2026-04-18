using OpenQA.Selenium;
using C_AutomationFramework.Utilities;

namespace C_AutomationFramework.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        private WaitHelper wait;

        // Locators
        private By Username => By.Id("username");
        private By Password => By.Id("password");
        private By LoginBtn => By.CssSelector("button[type='submit']");
        private By FlashMessage => By.Id("flash");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WaitHelper(driver);
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
        }

        public void Login(string username, string password)
        {
            wait.WaitForElementVisible(Username).SendKeys(username);
            wait.WaitForElementVisible(Password).SendKeys(password);
            wait.WaitForElementClickable(LoginBtn).Click();
        }

        public string GetFlashMessage()
        {
            return wait.WaitForElementVisible(FlashMessage).Text;
        }
    }
}