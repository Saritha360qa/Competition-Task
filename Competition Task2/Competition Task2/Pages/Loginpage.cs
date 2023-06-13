using Competition_Task2.utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace Competition_Task2.Pages
{
    public class LoginPage
    {   

        //Click on Login Button
        [FindsBy(How = How.XPath, Using = "//*[@id=\"home\"]/div/div/div[1]/div/a")]
        public IWebElement SignInButton { get; set; }

        //Enter the EmailID
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[1]/input")]
        public IWebElement EmailID { get; set; }

        //Enter the Password
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[2]/input")]
        public IWebElement Password { get; set; }

        //Click on remember me Checkbox
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[3]/div/input")]
        public IWebElement Checkbox { get; set; }

        //Click on Login button
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        public IWebElement Login { get; set; }      
    }
}
