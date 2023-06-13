using OpenQA.Selenium;

namespace Competition_Task2.Utilities.Common
{
    public class Browser
    {
        private IWebDriver driver;
        public Browser (IWebDriver driver)
        {
            this.driver = driver;
        }
        public string GetScreenshot()
        {
            var file = ((ITakesScreenshot)driver).GetScreenshot();
            string img = file.AsBase64EncodedString;

            return img;
        }
    }
}
