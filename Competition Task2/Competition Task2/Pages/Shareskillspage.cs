using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Competition_Task2.Pages
{
    public class Shareskillspage
    {
        //Enter Title
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        public IWebElement Title { get; set; }

        //Enter Description
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")]
        public IWebElement Description { get; set; }

        //Click on Category
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select")]
        public IWebElement Category{ get; set; }

        //Click on MusicAudio option
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[6]")]
        public IWebElement MusicAudio { get; set; }

        //Click on Subcategory 
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select")]
        public IWebElement Subcategory { get; set; }

        //Click on Voiceover
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[3]")]
        public IWebElement VoiceOver { get; set; }

        //Enter Tags
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div[1]/div/div/div/input")]
        public IWebElement Tags { get; set; }

        //Click on One-off service button
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        public IWebElement Oneoffservice { get; set; }

        //Click on Onsite button
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        public IWebElement Onsite { get; set; }

        //Enter start date
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input")]
        public IWebElement Startdate { get; set; }

        //Enter End date
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")]
        public IWebElement Enddate { get; set; }

        //Click on sunday
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input")]
        public IWebElement Sunday { get; set; }

        //Click on Monday
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input")]
        public IWebElement Monday { get; set; }

        //Click on Tuesday
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input")]
        public IWebElement Tuesday { get; set; }

        //Click on Sundaystarttime
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input")]
        public IWebElement Sundaystarttime { get; set; }

        //Click on Sundayendtime
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input")]
        public IWebElement Sundayendtime { get; set; }

        //Click on Mondaystarttime
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input")]
        public IWebElement Mondaystarttime { get; set; }

        //Click on Mondayendtime
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input")]
        public IWebElement Mondayendtime { get; set; }

        //Click on Tuesdaystarttime
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input")]
        public IWebElement Tuesdaystarttime { get; set; }

        //Click on Tuesdayendtime
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input")]
        public IWebElement Tuesdayendtime { get; set; }

        //Click on Credit button
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        public IWebElement Credit { get; set; }

        //Click on Credit value
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/input")]
        public IWebElement Creditvalue { get; set; }        

        //Upload Worksamples
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        public IWebElement Worksamples { get; set; }

        //Click on active
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]
        public IWebElement Active { get; set; }

        //Click on Save button

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]")]
        public IWebElement Save{ get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div")]
        public IWebElement toastMessage;
    }
}