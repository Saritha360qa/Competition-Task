using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace Competition_Task2.Pages
{
    public class Homepage
    {
        //Click on Shareskills Button
        [FindsBy(How = How.XPath, Using = "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a")]
        public IWebElement ShareskillsButton { get; set; }

        //Click on Manage listings Button
        [FindsBy(How = How.XPath, Using = "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]")]
        public IWebElement ManageskillsButton { get; set; }
    }
}
