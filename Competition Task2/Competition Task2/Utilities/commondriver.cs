using Competition_Task2.Pages;
using Competition_Task2.Utilities;
using Competition_Task2.Utilities.Common;
using Competition_Task2.Utilities.Reports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System.Reflection;

namespace Competition_Task2.utilities
{
    public class Commondriver
    {
        protected IWebDriver driver { get; private set; }
        protected Browser Browser { get; private set; }

        [SetUp]
        public void LoginSteps()
        {
            ExtentReporting.CreateTest(TestContext.CurrentContext.Test.MethodName);
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://localhost:5000/";
            Exceldatareader.ClearData();

            var loginpage = new LoginPage();
            PageFactory.InitElements(driver, loginpage);
            Thread.Sleep(2000);            
            loginpage.SignInButton.Click();
            //Exceldatareader.populateCollection(@"C:\Users\ramka\OneDrive\Desktop\Loginpage.xlsx");
            Exceldatareader.populateCollection(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"..\..\..\..\DataFiles\Loginpage.xlsx");
            loginpage.EmailID.SendKeys(Exceldatareader.ReadData(1, "Column1"));
            loginpage.Password.SendKeys(Exceldatareader.ReadData(1, "Column2"));
            //loginpage.EmailID.SendKeys("saritha@grr2.la");
            //loginpage.Password.SendKeys("Test1235");
            
            loginpage.Checkbox.Click();            
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[4]/button", 10);
            loginpage.Login.Click();            
            Browser = new Browser(driver);
        }

        [TearDown]
        public void Closetestrun()
        {
            EndTest();
            driver.Quit();          
            ExtentReporting.EndReporting();
        }
        private void EndTest()
        {
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            var message = TestContext.CurrentContext.Result.Message;

            switch (testStatus)
            {
                case TestStatus.Failed:
                    ExtentReporting.LogFail($"Test has failed{message}");
                    break;
                case TestStatus.Skipped:
                    ExtentReporting.LogInfo($"Test skipped {message}");
                    break;
                default:
                    break;
            }
            ExtentReporting.LogInfo("Ending Test");            
        }
    }
}