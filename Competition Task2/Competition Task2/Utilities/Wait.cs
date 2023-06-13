using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Competition_Task2.utilities
{
    public class Wait
    {
        public static void WaitToBeClickable(IWebDriver Driver, string locatortype, string locatorvalue, int seconds)
        {
            var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));

            if (locatortype == "XPath")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));
            }
            if (locatortype == "Id")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorvalue)));
            }
            if (locatortype == "Cssselector")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorvalue)));
            }
        }
        public static void WaitForELementToExist(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locatorType == "XPath")
            {
                wait.Until(OpenQA.Selenium.Support.UI.ExpectedConditions.ElementExists(By.XPath(locatorValue)));
            }
            if (locatorType == "Id")
            {
                wait.Until(OpenQA.Selenium.Support.UI.ExpectedConditions.ElementExists(By.Id(locatorValue)));
            }
            if (locatorType == "CssSelector")
            {
                wait.Until(OpenQA.Selenium.Support.UI.ExpectedConditions.ElementExists(By.CssSelector(locatorValue)));
            }
            if (locatorType == "Name")
            {
                wait.Until(OpenQA.Selenium.Support.UI.ExpectedConditions.ElementExists(By.Name(locatorValue)));
            }
        }
    }
}