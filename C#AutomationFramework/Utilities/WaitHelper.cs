using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace C_AutomationFramework.Utilities
{
    public class WaitHelper
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public WaitHelper(IWebDriver driver, int timeoutSeconds = 10)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));
        }

        public IWebElement WaitForElementVisible(By locator)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public IWebElement WaitForElementClickable(By locator)
        {
            return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public bool WaitForElementExists(By locator)
        {
            return wait.Until(ExpectedConditions.ElementExists(locator)) != null;
        }
    }
}