using AutoIt;
using Competition_Task2.Pages;
using Competition_Task2.utilities;
using Competition_Task2.Utilities;
using Competition_Task2.Utilities.Reports;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Reflection;

namespace Competition_Task2.Tests
{
    [TestFixture]
    public class CreateEditDeleteTests : Commondriver
    {
       Homepage homepage = new Homepage();
        
        [Test, Order(1)]
        public void CreateTests()
        {
            ExtentReporting.LogInfo("Starting test - submit form");

            var homepage = new Homepage();
            PageFactory.InitElements(driver, homepage);            
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a", 10);
            homepage.ShareskillsButton.Click();            

            var shareskillspage = new Shareskillspage();
            PageFactory.InitElements(driver, shareskillspage);            
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input", 10);
            shareskillspage.Title.SendKeys(Exceldatareader.ReadData(1, "Column3"));
            shareskillspage.Description.SendKeys(Exceldatareader.ReadData(1, "Column4"));
            shareskillspage.Category.Click();            
            shareskillspage.MusicAudio.Click();
            shareskillspage.Subcategory.Click();
            shareskillspage.VoiceOver.Click();            
            shareskillspage.Tags.Click();
            shareskillspage.Tags.SendKeys(Exceldatareader.ReadData(1, "Column5"));
            shareskillspage.Tags.SendKeys(Keys.Enter);
            shareskillspage.Oneoffservice.Click();            
            shareskillspage.Onsite.Click();
            shareskillspage.Startdate.SendKeys(Exceldatareader.ReadData(1, "Column6"));
            shareskillspage.Enddate.SendKeys(Exceldatareader.ReadData(1, "Column7"));
            shareskillspage.Sunday.Click();
            shareskillspage.Sundaystarttime.SendKeys(Exceldatareader.ReadData(1, "Column8"));
            shareskillspage.Sundayendtime.SendKeys(Exceldatareader.ReadData(1, "Column9"));
            shareskillspage.Monday.Click();
            shareskillspage.Mondaystarttime.SendKeys(Exceldatareader.ReadData(1, "Column10"));
            shareskillspage.Mondayendtime.SendKeys(Exceldatareader.ReadData(1, "Column11"));
            shareskillspage.Tuesday.Click();
            shareskillspage.Tuesdaystarttime.SendKeys(Exceldatareader.ReadData(1, "Column12"));
            shareskillspage.Tuesdayendtime.SendKeys(Exceldatareader.ReadData(1, "Column13"));
            shareskillspage.Credit.Click();
            shareskillspage.Creditvalue.SendKeys(Exceldatareader.ReadData(1, "Column14"));
            shareskillspage.Worksamples.Click();
            Exceldatareader.ClearData();

            AutoItX.ControlFocus("Open", "", "Edit1");
            AutoItX.Sleep(1000);
            //AutoItX.ControlSetText("Open", "", "Edit1", "C:\\Users\\ramka\\Downloads\\File1.txt");
            AutoItX.ControlSetText("Open", "", "Edit1", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"..\..\..\..\DataFiles\File1.txt");

            AutoItX.Sleep(1000);
            AutoItX.ControlClick("Open", "", "Button1");

            shareskillspage.Active.Click();            
            shareskillspage.Save.Click();
            Wait.WaitForELementToExist(driver, "XPath", "/html/body/div[1]/div", 15);
            string ActualToastMessage = shareskillspage.toastMessage.Text;
            Console.WriteLine(ActualToastMessage);
            
        }

        [Test,Order(2)]
        public void EditTests()
        {
            ExtentReporting.LogInfo($"write Edit tests");

            PageFactory.InitElements(driver, homepage);            
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]", 15);
            homepage.ManageskillsButton.Click();
            
            var managelistingspage = new Managelistingspage();
            PageFactory.InitElements(driver, managelistingspage);
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i", 25);            
            managelistingspage.EditButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input", 25);            
            managelistingspage.EditTitle.Clear();
            managelistingspage.EditTitle.SendKeys(Exceldatareader.ReadData(6, "Column0"));
            managelistingspage.EditDescription.Clear();
            managelistingspage.EditDescription.SendKeys(Exceldatareader.ReadData(6, "Column1"));
            managelistingspage.EditCategory.Click();            
            managelistingspage.FunLifestyle.Click();
            managelistingspage.EditSubcategory.Click();
            managelistingspage.Astrology.Click();            
            managelistingspage.EditTags.Click();
            managelistingspage.AddnewTags.Click();
            managelistingspage.AddnewTags.SendKeys(Exceldatareader.ReadData(6, "Column2"));
            managelistingspage.AddnewTags.SendKeys(Keys.Enter);
            managelistingspage.Hourlybasisservice.Click();            
            managelistingspage.Online.Click();
            managelistingspage.EditStartdate.SendKeys(Exceldatareader.ReadData(6, "Column3"));
            managelistingspage.EditEnddate.SendKeys(Exceldatareader.ReadData(6, "Column4"));
            managelistingspage.Wednesday.Click();
            managelistingspage.Thursday.Click();
            managelistingspage.Wednesdaystarttime.Clear();
            managelistingspage.Wednesdaystarttime.SendKeys(Exceldatareader.ReadData(6, "Column5"));
            managelistingspage.Wednesdaystarttime.Clear();
            managelistingspage.Wednesdayendtime.SendKeys(Exceldatareader.ReadData(6, "Column6"));
            managelistingspage.Wednesdaystarttime.Clear();
            managelistingspage.Thursdaystarttime.SendKeys(Exceldatareader.ReadData(6, "Column7"));
            managelistingspage.Wednesdaystarttime.Clear();
            managelistingspage.Thursdayendtime.SendKeys(Exceldatareader.ReadData(6, "Column8"));
            managelistingspage.Credit.Click();
            managelistingspage.EditCreditvalue.SendKeys(Exceldatareader.ReadData(6, "Column9"));            
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i", 25);                       
            managelistingspage.newWorksamples.Click();
            Exceldatareader.ClearData();

            AutoItX.ControlFocus("Open", "", "Edit1");
            AutoItX.Sleep(1000);
            //AutoItX.ControlSetText("Open", "", "Edit1", "C:\\Users\\ramka\\Downloads\\pexels-pixabay-56866.jpg");
            AutoItX.ControlSetText("Open", "", "Edit1", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"..\..\..\..\DataFiles\pexels-pixabay-56866.jpg");
            AutoItX.Sleep(1000);
            AutoItX.ControlClick("Open", "", "Button1");

            managelistingspage.Hidden.Click();
            managelistingspage.Save.Click();            
            Wait.WaitForELementToExist(driver, "XPath", "/html/body/div[1]/div", 15);

            string ActualToastMessage = managelistingspage.toastMessage.Text;
            Console.WriteLine(ActualToastMessage);            
        }

        [Test,Order(3)]
        public void DeleteTests()
        {
            ExtentReporting.LogInfo($"write Delete tests");

            PageFactory.InitElements(driver, homepage);            
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]", 15);
            homepage.ManageskillsButton.Click();            

            var managelistingspage = new Managelistingspage();
            PageFactory.InitElements(driver, managelistingspage);

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i", 15);
            managelistingspage.DeleteButton.Click();
            managelistingspage.YesButton.Click();
            Thread.Sleep(2000);
            
            string ActualMessage = managelistingspage.AlertWindow.Text;
            Console.WriteLine("Toast message Captured was: "+ActualMessage);
            Assert.That(ActualMessage == "Chess for beginners has been deleted", "Actual message and expected message do not match");
        }
    }
}