using Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace Competition_Task2.Pages
{
    public class Managelistingspage
    {
        //Clickon EditButton
        [FindsBy(How = How.XPath, Using = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i")]
        public IWebElement EditButton { get; set; }

        //Enter Title
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        public IWebElement EditTitle { get; set; }

        //Enter Description
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")]
        public IWebElement EditDescription { get; set; }

        //Click on Category
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select")]
        public IWebElement EditCategory { get; set; }

        //Click on MusicAudio option
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[9]")]
        public IWebElement FunLifestyle { get; set; }

        //Click on Subcategory 
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select")]
        public IWebElement EditSubcategory { get; set; }

        //Click on Voiceover
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[4]")]
        public IWebElement Astrology { get; set; }

        //Edit Tags
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/span/a")]
        public IWebElement EditTags { get; set; }

        //Enter Tags
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div[1]/div/div/div/input")]
        public IWebElement AddnewTags { get; set; }

        //Edit Hourly basis service
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        public IWebElement Hourlybasisservice { get; set; }

        //Click on Online button
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        public IWebElement Online { get; set; }

        //Enter start date
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input")]
        public IWebElement EditStartdate { get; set; }

        //Enter End date
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")]
        public IWebElement EditEnddate { get; set; }

        //Click on Wednesday
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input")]
        public IWebElement Wednesday { get; set; }

        //Click on Thursday
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[6]/div[1]/div/input")]
        public IWebElement Thursday { get; set; }

        //Click on Wednesdaystarttime
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input")]
        public IWebElement Wednesdaystarttime { get; set; }


        //Click on Wednesdayendtime
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input")]
        public IWebElement Wednesdayendtime { get; set; }

        //Click on Wednesdaystarttime
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input")]
        public IWebElement Thursdaystarttime { get; set; }

        //Click on Wednesdayendtime
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input")]
        public IWebElement Thursdayendtime { get; set; }

        //Click on Credit Skillltrade button
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        public IWebElement Credit { get; set; }

        //Click on Credit value
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/input")]
        public IWebElement EditCreditvalue { get; set; }

        //Upload  newWorksamples
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        public IWebElement newWorksamples { get; set; }

        //Click on Hidden
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]
        public IWebElement Hidden { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]")]
        public IWebElement Save { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div")]
        public IWebElement toastMessage;   

        //Clickon DeleteButton
        [FindsBy(How = How.XPath, Using = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i")]
        public IWebElement DeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        public IWebElement YesButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div")]
        public IWebElement AlertWindow { get; set; }
    }
}